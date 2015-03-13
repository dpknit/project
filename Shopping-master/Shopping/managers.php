<?php
// login data:
$host = "localhost";
$user = "root";
$pw = "";
$database = "shopping";

// connects to the database:
$db = mysql_connect($host,$user,$pw) or die("Cannot connect to MySQL.");
mysql_select_db($database,$db) or die("Cannot connect to database.");
?>

<!-- View products and prices -->
<h2>View all products and prices:</h2>
<form method="GET" action="update.php">
<table border="1">
<tr><th>Product ID</th><th>Product Description</th><th>Price</th><th>Quantity</th></tr>
<?php
$command = "select * from products;";
$result = mysql_query($command);
while($data = mysql_fetch_object($result)) {
  print "<tr><td>".$data->product_id."</td>
             <td>".$data->description."</td>
             <td>CAD \$".$data->price."</td>
             <td>$data->quantity</td></tr>";
}
?>
</table><br><br>

<!-- View customers and purchases -->
<h2>View customers and purchases:</h2>
<table border="1">
<tr><th>Purchase ID</th><th>Product ID</th><th>Quantity</th>
    <th>Customer ID</th><th>Date</th><th>Price</th></tr>
<?php
$command = "select * from purchases;";
$result = mysql_query($command);
while($data = mysql_fetch_object($result)) {
  print "<tr><td>".$data->purchase_id."</td>
             <td>".$data->product_id."</td>
             <td>".$data->quantity."</td>
             <td>".$data->customer_id."</td>
             <td>".$data->date."</td>
             <td>CAD \$".$data->price."</td>";
}
mysql_close($db);
?>
</table><br><br>

<h2>Update products and prices:</h2>
<table border="1">
<tr><th>Product ID</th><th>Price</th><th>Quantity</th></tr>
<tr><td><input type="text" name="product_id_u"/></td>
    <td><input type="text" name="price_u"/></td>
    <td><input type="text" name="quantity_u"/></td></tr>
</table>
<br><input type="submit" name="Update" value="Update"/><br><br>

<h2>Add a product:</h2>
<table border="1">
<tr><th>Product Description</th><th>Price</th><th>Quantity</th></tr>
<tr><td><input type="text" name="description_a"/></td>
    <td><input type="text" name="price_a"/></td>
    <td><input type="text" name="quantity_a"/></td></tr>
</table>
<br><input type="submit" name="Add" value="Add" /><br>

</form>