<?php
// script to execute, when the form is submitted:
if(isset($_POST["submit"])) {
    
    // conect to the MySQL server:
    $con = mysql_connect("localhost","root","");
    if (!$con) {
        die('Could not connect: ' . mysql_error());
    }
    
    // create database:
    if (mysql_query("CREATE DATABASE shopping", $con)) {
        echo "Database created";
    } else {
        echo "Error creating database: " . mysql_error();
    }
    // select database:
    mysql_select_db("shopping", $con);
    
    // create table customers:
    $sql = "CREATE TABLE customers (customer_id int NOT NULL AUTO_INCREMENT, name varchar(100), email varchar(100),
            PRIMARY KEY (customer_id));";
    if(mysql_query($sql,$con)) {
        echo "Table customers created";
    } else {
        echo "Error creating table customers: " . mysql_error();
    }
    // create table products:
    $sql = "CREATE TABLE products (product_id int NOT NULL AUTO_INCREMENT, description varchar(100), price float(5),
            quantity int(3), PRIMARY KEY (product_id));";
    if(mysql_query($sql,$con)) {
        echo "Table products created";
    } else {
        echo "Error creating table products: " . mysql_error();
    }
    // create table purchases:
    $sql = "CREATE TABLE purchases (purchase_id int NOT NULL AUTO_INCREMENT, product_id int(3), quantity int(3), 
            customer_id int(3), date date, price float (5), PRIMARY KEY (purchase_id));";
    if(mysql_query($sql,$con)) {
        echo "Table purchases created";
    } else {
        echo "Error creating table purchases: " . mysql_error();
    }
    
    // insert sample data into the products table:
    $sql = "INSERT INTO products (description, price, quantity) VALUES ('The Witchs Daughter By Paula Brackston',
           '12.26', '15')";
    if(mysql_query($sql,$con)) {
        echo "Product added";
    } else {
        echo "Error adding product: " . mysql_error();
    }
    $sql = "INSERT INTO products (description, price, quantity) VALUES ('A Discovery of Witches By Deborah Harkness', 
           '12.27', '47')";
    if(mysql_query($sql,$con)) {
        echo "Product added";
    } else {
        echo "Error adding product: " . mysql_error();
    }
    $sql = "INSERT INTO products (description, price, quantity) VALUES ('The Twelve By Justin Cronin', 
           '20.65', '91')";
    if(mysql_query($sql,$con)) {
        echo "Product added";
    } else {
        echo "Error adding product: " . mysql_error();
    }
    $sql = "INSERT INTO products (description, price, quantity) VALUES ('The Exile of Sara Stevenson By Darci Hannah', 
           '12.64', '54')";
    if(mysql_query($sql,$con)) {
        echo "Product added";
    } else {
        echo "Error adding product: " . mysql_error();
    }
    $sql = "INSERT INTO products (description, price, quantity) VALUES ('The Secret Keeper By Kate Morton', 
           '18.80', '27')";
    if(mysql_query($sql,$con)) {
        echo "Product added";
    } else {
        echo "Error adding product: " . mysql_error();
    }
    $sql = "INSERT INTO products (description, price, quantity) VALUES ('A Woman Of The Otherworld By Kelley Armstrong', 
           '18.87', '71')";
    if(mysql_query($sql,$con)) {
        echo "Product added";
    } else {
        echo "Error adding product: " . mysql_error();
    }
    $sql = "INSERT INTO products (description, price, quantity) VALUES ('Deadlocked: A Sookie Stackhouse By Paula Brackston', 
           '18.50', '63')";
    if(mysql_query($sql,$con)) {
        echo "Product added";
    } else {
        echo "Error adding product: " . mysql_error();
    }
    $sql = "INSERT INTO products (description, price, quantity) VALUES ('The Book of Shadows By Phyllis Curott', 
           '12.81', '47')";
    if(mysql_query($sql,$con)) {
        echo "Product added";
    } else {
        echo "Error adding product: " . mysql_error();
    }
    mysql_close($con);
}
?>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html" charset=utf-8"/>
<title>Book Store, Inc.</title>
<link rel="stylesheet" href="style.css" type="text/css" />
<title>Install tables</title>
</head>

<body>
<?php include 'top.inc'; ?>
<h2>Welcome to the Book Store Inc. installation page</h2>
<form method="post" action="">
<p>Click "Install" to populate the tables:</p>
<p><input type='submit' name='submit' value='Install'/></p>
<?php include 'bottom.inc'; ?>
</form>
</body>
</html>
