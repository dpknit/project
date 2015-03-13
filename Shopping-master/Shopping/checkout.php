<?php
    // variables; load data from the previous page:
    session_start();
    $product_id_array = $_SESSION['product_id_array'];
    $quantity_array = $_SESSION['quantity_array'];
    $existing_customer = false; // flag
    $customer_id = 0;
    $name = $_GET['name'];
    $email = $_GET['email'];
    $message = "";  // email message
    $valid = false; // flag
    // login data:
    $host = "localhost";
    $user = "root";
    $pw = "";
    $database = "shopping";
    // connects to the database:
    $db = mysql_connect($host,$user,$pw) or die("Cannot connect to MySQL.");
    mysql_select_db($database,$db) or die("Cannot connect to database.");
?>

<!DOCTYPE html>
<html>
    <head>
        <title>Book Store, Inc.</title>
        <link rel="stylesheet" href="style.css" type="text/css" />
    </head>
    <body>
        <?php include 'top.inc';
        // form validation:
        if(!$name) {
            print "Please navigate back to the previous page and enter your name.";
        } else if(!$email) {
            print "Please navigate back to the previous page and enter your email.";
        } else if(count($product_id_array)==0) {
            print "Your shopping cart is empty.";
        } else {
            $valid = true;
        }
        // check for returning customer:
        if($valid) {
            $command = "select name from customers;";
            $result = mysql_query($command);
            while($data = mysql_fetch_object($result)) {
                if($data->name == $name) {
                    print "Welcome back ".$name."!";
                    $existing_customer = true;
                }
            }
            if(!$existing_customer) {
                // register the customer:
                print "Welcome ".$name."!";
                $command = "insert into customers (name, email) values ('$name', '$email');";
                $result = mysql_query($command);
            }

            // get customer_id:
            $command = "select customer_id from customers where name='$name';";
            $result = mysql_query($command);
            $data = mysql_fetch_object($result);
            $customer_id = $data->customer_id;

            // checkout screen:
            print "<h2>Summary of your order:</h2>";
            print "Name: ".$name."<br>E-mail: ".$email."<br><br>";
            for($i=0; $i<count($product_id_array); $i++) {
                // prints an order receipt:
                $command = "select * from products where product_id='$product_id_array[$i]';";
                $result = mysql_query($command);
                $data = mysql_fetch_object($result);
                print $data->description."<br>
                      CAD \$".$data->price."<br>
                      Quantity: ".$quantity_array[$i]."<br><br>";
                $message = $message.$data->description."<br/>
                                    CAD \$".$data->price."<br/>
                                    Quantity: ".$quantity_array[$i]."<br/><br/>";
                // updates the database tables; deduct the quantity sold:
                $command = "update products set quantity=quantity-$quantity_array[$i] where product_id=$product_id_array[$i];";
                $result = mysql_query($command);
                // get price of the product:
                $command = "select price from products where product_id=$product_id_array[$i];";
                $result = mysql_query($command);
                $data = mysql_fetch_object($result);
                $price = $data->price;
                // register the purchase:
                $command = "insert into purchases (product_id, quantity, customer_id, date, price)
                            values ('$product_id_array[$i]', '$quantity_array[$i]', '$customer_id', now(), '$price');";
                $result = mysql_query($command);
            }
            print "<h2>Thank you for shopping from example.com!</h2>";
            
            // send confirmation e-mail:
            function mail_message($template_file, $name, $email, $message) {
                #get template content, and replace variables with data:
                $email_message = file_get_contents($template_file);
                $email_message = str_replace("#DATE#", date("F d, Y h:i a"), $email_message);
                $email_message = str_replace("#NAME#", $name, $email_message);
                $email_message = str_replace("#EMAIL#", $email, $email_message);
                $email_message = str_replace("#SUBJECT#", "Your order", $email_message);
                $email_message = str_replace("#MESSAGE#", $message, $email_message);
                #construct the email headers
                $to = $email;
                $from = "book_store_inc@example.ca";
                $email_subject = time().": Your order";
                // convert $message to text for e-mail:
                $email_message=$email_message."Thank you for shopping from Book Store Inc.";
                $email_message = str_replace("<br/>", "\n", $email_message);
                # send mail
                mail($to, $email_subject, $email_message, "From: ".$from);
            }
            mail_message("email_template.txt", $name, $email, $message);
        }
        mysql_close($db);
        include 'bottom.inc';
        ?>
    </body>
</html>