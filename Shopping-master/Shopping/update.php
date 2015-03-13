<?php

// login data:
$host = "localhost";
$user = "root";
$pw = "";
$database = "shopping";

// connects to the database:
$db = mysql_connect($host,$user,$pw) or die("Cannot connect to MySQL.");
mysql_select_db($database,$db) or die("Cannot connect to database.");

// Updates products and prices:
if(isset($_GET['Update'])) {
  $price=$_GET['price_u'];
  $quantity=$_GET['quantity_u'];
  $product_id=$_GET['product_id_u'];
  $command = "update products set price=$price where product_id=$product_id;";
  $result = mysql_query($command);
  $command = "update products set quantity=$quantity where product_id=$product_id;";
  $result = mysql_query($command);
  print "Data has been updated.";
}

// Adds a new product:
if(isset($_GET['Add'])) {
  $description=$_GET['description_a'];
  $price=$_GET['price_a'];
  $quantity=$_GET['quantity_a'];
  $command = "insert into products (description, price, quantity) values ('$description',
              '$price', '$quantity');";
  $result = mysql_query($command);
  print "Data has been added.";
}

mysql_close($db);
?>