x :: Int
x = 10

f :: Int -> Int
f x = let y = 3
          z = 2
          in x*y + x*z 


main = do
    print (f x)

