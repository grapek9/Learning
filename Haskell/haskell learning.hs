 

rec 1 = 1
rec x = x * rec (x-1)
list = [1..999]

main = do
    print (rec 1)
    print list 
    print (sum(filter (\n->n `mod` 3==0 || n`mod`5==0) list))
