<html>
<head>
<title>Menghitung Luas Lingkaran</title>
</head>
<body>
<?
//Konstanta untuk Nilai Judul 
define("Judul","Hitung Luas Lingkaran"); 
//Konstanta Untuk Nilai phi
define("phi",3.14);
echo Judul;
$r=10;
echo"<br>Jari-jari:$r<br>\n";
$luas=phi*$r*$r;
echo"Luas Lingkaran=$luas";
?>
</body>
</html>