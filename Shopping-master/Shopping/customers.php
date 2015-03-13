<?php
  if (isset($_GET['delete_session'])) {
    setcookie("PHPSESSID",""); //force the session to end
  }
  else {
    #start the session before any output
    session_start();
  }
  
  if ($_GET['error'] == "1") {
    $error_code = 1;  // missing entry
  }
  if ($_GET['error'] == "2") {
    $error_code = 2;  // invalid e-mail
  }
?>

<h3>Please login to your account, to access our products:</h3>

<?
  if($error_code == 1) {
    echo "<div style='color:red'>You have to enter all required data:</div>";
  }
  else if($error_code == 2) {
    echo "<div style='color:red'>You have to enter a valid e-mail address:</div>";
  }
?>

<!-- this is a login form with name and email fields -->
<form method="GET" action="products.php">
<table>
  <tr>
    <td align="right">
      Name:
    </td>
    <td align="left">
      <?
      if ($_SESSION['name']) {
        echo $_SESSION['name']; 
      ?>
      <a href="login.php?delete_session=1">Not <? echo $_SESSION['name']; ?>?</a>
      <?
      }
      else {
      ?>
        <input type="text" size="25" name="name" value="<? echo $_GET['name']; ?>" />
        <input type="checkbox" name="remember" /> Remember me on this computer
      <?
      }
      if ($error_code==1 && !($_GET['name'] || $_SESSION['name'])) {
        echo "<b>You have to enter your name.</b>";
      }
      ?>
    </td>
  </tr>
  <tr>
    <td align="right">
      Email:
    </td>
    <td align="left">
      <?
      if ($_SESSION['email']) {
        echo $_SESSION['email'];
      } 
      ?>
        <input type="text" size="25" name="email" value="<? echo $_GET['email']; ?>" />
      <?
      if ($error_code==1 && !($_GET['email'] || $_SESSION['email'])) {
        echo "<b>You have to enter your email address.</b>";
      }
      ?>
    </td>
  </tr>
  <tr>
    <td colspan="2">
      <input type="checkbox" name="update1" checked="checked" />Please email me updates about your products.<br/>
      <input type="checkbox" name="update2" />Please email me updates about products from third-party partners.
    </td>
  </tr>
  <tr>
    <td colspan="2" align="center">
      <input type="submit" value="SUBMIT" />
    </td>
  </tr>
</table>
</form>