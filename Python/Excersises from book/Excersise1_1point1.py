char = "#"
blank = ""
print("Excersise 1 , 1.1")
for i in range(0,4):
	print(blank,end=" ")
	for j in range(0,8-i*2):
		print(char,end=" ")
	print("")
	blank+="  "