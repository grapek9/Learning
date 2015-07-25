// numeric types in scala !!
//basic types!!
"Byte"
Byte.MinValue
Byte.MaxValue
"Short"
Short.MinValue
Short.MaxValue
"Int"
Int.MinValue
Int.MaxValue
"Long"
Long.MinValue
Long.MaxValue
"Float"
Float.MinPositiveValue
Float.MinValue
Float.MaxValue
"Double"
Double.MinPositiveValue
Double.MinValue
Double.MaxValue
"Big Int"
BigInt("2") // creating straight from int
"Big Decimal"
BigDecimal("2") // creating straight from int
//Parsing from string
"Parsing from string"
"Int"
"100".toInt
"Double"
"100".toDouble
"Float"
"100".toFloat
"Long"
"100".toLong
"Short"
"100".toShort
"Byte"
"100".toByte
"example exteption comented cus excetption block further code"
//"foo".toInt
//Conversion to other bases
"Conversion to other base"
"Traditional way"
"base 2, and number 10"
Integer.parseInt("10",2)
"base 3"
Integer.parseInt("10",3)
"base 4"
Integer.parseInt("10",4)
"base 5"
Integer.parseInt("10",5)
"base 6"
Integer.parseInt("10",6)
"base 7"
Integer.parseInt("10",7)
"base 8"
Integer.parseInt("10",8)
"base 9"
Integer.parseInt("10",9)
"base 10"
Integer.parseInt("10",10)
"And new way by implicit conversion"
implicit class MagicStringToInt(s:String){ //i can override basic version but all code above generates warrning then so i made name toIntNewWay
  def toIntNewWay(radix:Int) = Integer.parseInt(s,radix)
}
"and example"
"1".toIntNewWay(2)
"1".toIntNewWay(3)
"1".toIntNewWay(4)
"1".toIntNewWay(5)
"1".toIntNewWay(6)
implicit class megaplus(x:Int){
  def ++(x) = x= x+ 1
}

