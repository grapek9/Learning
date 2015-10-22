 

rec 1 = 1

rec x = x * rec (x-1)


main = do
    print (rec 1000)

