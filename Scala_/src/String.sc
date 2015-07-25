import scala.util.matching.Regex
val string1 = "some string ;)"
string1 //displaying String
string1.length() //counting letters in string
val string2 = "Hello " + " World" //concatenate strings
string2.length //length without ();
string1.foreach(println) // treating string asa sequence of characters

for (c <- string1) println(c)
string2
string2.getBytes.foreach(println) // displaying bytes of hello world
// using filter
val result = string2.filter(_ != 'l') // string without ' l '
result
val string3= "scala"
string3.drop(2).take(2).capitalize // adding methods to closed class 1. drop first 2 letters , 2.take only 2 of 3 left letters ,3 capitalize them
// string equality
val s1 = "Hello"
val s2 = "Hello"
s1==s2
s1.toUpperCase == s2.toUpperCase
val s3 = null
s1.equalsIgnoreCase(s2)
s1==s3
// multiline strings
val s4 = """testing
  multiline
strings """
s4.length
//splitting string
val s5 = "Testing splitting method"
s5.split(" "); // result array of words
val s6 = "list , of, elements"
s6.split(",") // splitting
s6.split(",").map(_.trim) // splitting and cleaning up from " " spaces
//different split arguments
s5.split(" ") //string like
s5.split(' ') // char like
//variables in strings
val name ="John"
val age = 30
val weight = 90.00
println(s"Hello my name is $name ,I'am $age years old , and i weight $weight kg's")
//increasing age inside  string
println(s"in next year my age will be ${age + 1}")
case class Student(name:String ,age: Int)
val testStudent = Student("Killer",5) //accessing object properties in string
println(s"Test student name:${testStudent.name} and age:${testStudent.age}")
// pattern matching
val numPattern = "[0-9]+".r //adding regex object as a pattern
val adress = "123 Trololo Street 928"
val match1 = numPattern.findFirstIn(adress) // searching first group of numbers in strin
//returned "option" that has only 2 states  null and one hit
val matches = numPattern.findAllIn(adress) // getting all hits in string
//returns an iterator
matches.foreach(println) // display result
// you can make matches as array list or vector by example
val matches2 = numPattern.findAllIn(adress).toArray //array of results
//other way using regex object
val pattern = new Regex("[0-9]+") // and rest go like above
val matches3= pattern.findFirstIn(adress)
//option object have one val or none, one val is represented by some(...) ex
val adress2= "No Adress given"
val matches4= pattern.findFirstIn(adress2) // result option[string] = none
//to reach value hidden in option you have to call getOrElse method ex.
val matches5 = pattern.findFirstIn(adress2).getOrElse("No hits") // will display no hits text
val matches6 = pattern.findFirstIn(adress).getOrElse("no hits") // result matching string
// replacing patterns in string
// string is immutable so replacing will be going on new string object
val replace = "123 String street 345".replaceAll("[0-9]","x") // will replace all numbers with x
var reggex = "[0-9]".r // reggex way
val newAdress = reggex.replaceAllIn("123 lol street 223","x")
val result2 = "123".replaceFirst("[0-9]","x") //replaced first hit
reggex = "H".r
val result3 = reggex.replaceFirstIn("Hello World","J") // regex variable as pattern
// extracting part of string that match patterns
val pattern2 = "([0-9]+) ([A-Za-z]+)".r
val pattern2(count,fruit) = "200 bananas"
//reaching character at some space in string
"some string".charAt(3) // java way
"some string"(3) // scala way
//"some string"(3) deep inside scala is converted to "some string".apply(3)
//addind your own methods
//"HAL".inctrement
//by using implicit

implicit class SweetString(s:String){
  def increment = s.map(c => (c+1).toChar)
}
var result5 = "HAL".increment //result will be IBM, increased each char by 1


