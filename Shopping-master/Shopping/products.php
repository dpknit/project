<?php
    // login data:
    $host = 'localhost';
    $user = 'root';
    $pw = '';
    $database = 'shopping';
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
        <?php include 'top.inc'; ?>
        <!-- Prints the descriptions and the prices of all products: -->
        <h2>Please select from our products:</h2>
        <form method="GET" action="shopping_cart.php">
            <table border="1">
                <tr><th>Product Description</th><th>Price</th><th>Quantity</th></tr>
                <?php
                $command = "select * from products;";
                $result = mysql_query($command);
                $i = 0; // counter
                while($data = mysql_fetch_object($result)) {
                    print "<tr><td>".$data->description."</td><td>CAD \$".$data->price."</td><td>
                           <input type=number min=0 max=10 value=0 name=quantity$i /></td></tr>";
                    $i++;
                }
                mysql_close($db);
                ?>
            </table>
            <input type="submit" value="Add to cart" />
            <?php include 'bottom.inc'; ?>
        </form>
    </body>
</html>