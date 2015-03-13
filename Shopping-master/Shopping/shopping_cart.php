<?php
    // login data:
    $host = "localhost";
    $user = "root";
    $pw = "";
    $database = "shopping";
    // connects to the database:
    $db = mysql_connect($host,$user,$pw) or die("Cannot connect to MySQL.");
    mysql_select_db($database,$db) or die("Cannot connect to database.");

    // variables:
    $i=0; // indexes
    $j = 0;
    // session variables to pass the shopping cart to the next page:
    $product_id_array = array(); 
    $quantity_array = array();   
?>

<!DOCTYPE html>
<html>
    <head>
        <title>Book Store, Inc.</title>
        <link rel="stylesheet" href="style.css" type="text/css" />
    </head>
      
    <body>
        <?php include 'top.inc'; ?>
        <!-- Prints the shopping cart: -->
        <h2>Your shopping cart contains:</h2>
        <form method="GET" action="checkout.php">
            <?php
            // reads the database:
            $command = "select * from products;";
            $result = mysql_query($command);
            while($data = mysql_fetch_object($result)) {
                // displays only the selected into the shopping cart entries:
                if($_GET["quantity".$i]>0) {
                    print $data->description."<br>CAD \$".$data->price."<br>
                          Quantity: ".$_GET["quantity".$i]."<br><br>";
                    $product_id_array[$j] = $data->product_id;
                    $quantity_array[$j] = $_GET["quantity".$i];
                    $j++;
                }
                $i++;
            }
            if ($j == 0) {
                 echo "Your shopping cart is empty.<br><br>";
            }
            mysql_close($db);
            // save data into session variables for the next page:
            session_start();
            $_SESSION['product_id_array'] = $product_id_array;
            $_SESSION['quantity_array'] = $quantity_array;
            ?>
            <!-- Registration form: -->
            <h2>Please register to proceed to checkout:</h2>
            <table>
                <tr><td>Name:</td><td><input type="text" size="25" name="name"/></td></tr>
                <tr><td>E-mail:</td><td><input type="text" size="25" name="email"/></td></tr>
            </table>
            <br><input type="submit" value="Checkout"/>
            <h4>To add or remove products, please navigate to the previous page.</h4>
            <?php include 'bottom.inc'; ?>
        </form>
    </body>
</html>