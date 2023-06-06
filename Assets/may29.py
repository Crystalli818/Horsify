mylist = ["Ollie","Venadito","Willow","Ollie"]
mylist[0] = "Squiggles"
print (mylist)
myset = {"Ollie","Venadito","Willow","Ollie"}
print (myset)
mydictionary = {
    "cat" : "4 legged animal that meows",
    "year" : 2023
    }
print (mydictionary)
print(mylist[3])
print(mydictionary["cat"])

def my_function(fname):
    print("hello " + fname + " from my function"  )
    return "bye"

my_function("Ollie")
my_function("Amber")