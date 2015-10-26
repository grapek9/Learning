 

--rec 1 = 1
--rec x = x * rec (x-1)
--list = [1..999]
factorial 1 = 1
factorial x = x * factorial(x-1)
--main = do
--    print (rec 1)
 --   print list 
--    print (sum(filter (\n->n `mod` 3==0 || n`mod`5==0) list))
--n=10
--list = [1..n]
--main = do
--    print ((sum list)^^2-(sum(map(\n->n*n)list)))

sideLength = 20
fieldsize = 2*sideLength
factorial 1 = 1
factorial x = x * factorial(x-1)

main = do
	print ((factorial fieldsize)/((factorial sideLength)*(factorial (fieldsize-sideLength))))