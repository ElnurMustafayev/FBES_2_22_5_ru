# 1
#num = int(input())
#factorialResult = 1
#counter = num

#while counter > 0:
#    factorialResult *= counter
#    counter -= 1

#print(f'Factorial of {num} is {factorialResult}')



# 2
#num = int(input())
#counter = num

#sumResult = 0
#while True:
#    sumResult += counter
#    counter -= 1

#    if counter == 0:
#        break

#print(num, sumResult, counter)



# 3
#num = int(input())
#divNum = int(input())

#counter = num

#while True:
#    counter -= 1

#    if counter % divNum == 0:
#        print(counter)

#    if counter == 0:
#        break



# 4
#correctLogin = "123"
#correctPassword = "321"

#success = False

#tries = 3

#while not(success):
#    login = input("Login: ")
#    password = input("Password: ")

#    success = login == correctLogin and password == correctPassword

#    if success == False:
#        print("Incorrect credentials!")

#        tries -= 1
#        if tries == 0:
#            print("Error")
#            exit()

#        if input("Input 'exit' to exit or press 'enter' to try again... ") == "exit":
#            break;


#if success:
#    print("User logined successfully!")








#print("User 1:")
#nickname1 = input("Enter your nickname: ")
#age1 = int(input("Enter your age: "))

#if age1 < 0:
#    print("Error age can not be 0 or less!")
#else:
#    print(f"Welcome, {nickname1}!")



#print("User 2:")
#nickname2 = input("Enter your nickname: ")
#age2 = int(input("Enter your age: "))

#if age2 < 0:
#    print("Error age can not be 0 or less!")
#else:
#    print(f"Welcome, {nickname2}!")


#def TestFunction():
#    pass





#def SayHelloWorld():
#    print("Hello World!")




#def AskName():
#    name = input("Input your name: ")

#    if name == "stupid":
#        print("Incorrect!!!")
#    else:
#        print(f"Your name is {name}")


#AskName()
#AskName()
#AskName()



#def UserInfo():
#    name = input("Input your name: ")
#    surname = input("Input your surname: ")

#UserInfo()

#print(f"Hello {name} {surname}")


#def Func():
#    print(num)

#num = 123

#Func()




#name = "Elnur"

#def Func():
#    name = "Test"
#    print(name)         # Test

#Func()
#print(name)             # Elnur








#applicationName = "MyApp"
#name = "Unknown"

#def AskUsername():
#    global name
#    name = input("Input your name: ")


#def Welcome():
#    print(f"Dear {name}, Welcome to {applicationName}!")

#AskUsername()
#Welcome()








# Register() [name, surname, age]
# Validate() [age +18] "Success" / "Access denied!"




#def Register():
#    global name, surname, age

#    name = input("Name: ")
#    surname = input("Surname: ")
#    age = int(input("Age: "))

#def Validate():
#    global name, surname, age

#    if name == "" or surname == "":
#        print("Name and Surname must be filled")

#    #print(f"Age is {('' if age >= 18 else 'not')} OK")

#    print(("Age is OK" if age >= 18 else "Age is not OK"))

#    #print("Age is OK") if age >= 18 else print("Age is not OK")

#    #if age >= 18:
#    #    print("Age is OK")
#    #else:
#    #    print("Age is not OK")


#Register()
#Validate()







#username = "Usama"

#def RenameUser():
#    global username
#    #global cash

#    username = input(f"Input name to rename your old name '{username}'")
#    #cash = 0

#RenameUser()
#print(username)






#def Func(num):
#    print(num)

#num = 123
#Func(num)




#def Register():
#    global name, surname, age

#    name = input("Name: ")
#    surname = input("Surname: ")
#    age = int(input("Age: "))


#def Validate(age):
#    print("Age is OK" if age >= 18 else "Age is not OK")

#name = "Unknown"
#surname = "Unknown"
#age = -1

#Register()
#Validate(age)






#def Func(num):
#    print(num)

#x = 100

#Func(123)
#Func(x)
#Func(f"Test {x}")
#Func(123 == 777)
#Func(123 + 777)


#def Func(num):
#    print(num)

#Func(155)




#num = 10

#while num != 0:
#    print(num)
#    num -= 1



#def FromNumToZero(num):
#    while num != 0:
#        print(num)
#        num -= 1
#    print("\n\n\n")

#FromNumToZero(10)
#FromNumToZero(5)




#def Func(age):
#    if age >= 18:
#        print("Adult")
#    else:
#        print("Access denied")

#Func(5)
#Func(0)
#Func(-5)




#def Recursion(num):
#    num += 1
#    print(num)
#    Recursion(num)

#num = 0
#Recursion(num)





#def Recursion(num):
#    num += 1
#    print(num)

#    if num < 100:
#        Recursion(num)

#num = 0
#Recursion(num)





#def Recursion(num):
#    if num != 0:
#        print(num)
#        num += (-1 if num > 0 else 1)
#        Recursion(num)
#    else:
#        print(0)

#num = 20
#Recursion(num)



#name = input("Name: ")
#print(name)



#def GetNumber():
#    print("Start")
#    return 123
#    print("End")

#num = GetNumber()
#print(num)


#def Func():
#    while True:
#        print("one")
#        while True:
#            print("two")
#            return

#var = Func()
#print(var)



#def Func(num):
#    print(num)
#    return num > 5

#print(Func(-5))

#print(Func(5))

#print(Func(7))






#def ChangeNumber(num):
#    return num + 1

#num = 5
#print(ChangeNumber(ChangeNumber(ChangeNumber(num))))

#print(num)




#def IsAdult(age):
#    return age >= 18

#    #return True if age >= 18 else False

#    #if age >= 18:
#    #    return True
#    #else:
#    #    return False

#age = int(input("Age: "))
#isAdult = IsAdult(age)
#print(isAdult)


#def AskName():
#    return print("Test")
#    #return input("Name: ")

#name = AskName()
#print(name)



#def Func1():
#    print("F1")
#    Func2()

#def Func2():
#    Func1()
#    print("F2")

#Func1()




#def Func(num = 100):
#    print(num)
    
#Func(True)
#Func(None)
#Func()
#Func(10 - 10)



#def SayHelloToUser(name = "Unknown"):
#    print(f"Hello, {name}!")

#SayHelloToUser("Elnur")
#SayHelloToUser()






#def Func(num1, num2 = -1):
#    print(num1) # 10
#    print(num2) # -1

#Func(10)




#def Func(num2, num1 = 3, num3 = 1, num4 = True):
#    print(num1)
#    print(num2)
#    print(num3)
#    print(num4)

#num = 100
#Func(num1 = 1, num2 = num, num4 = 4, num3 = 3)




#def DublicateWords(count, word = "*"):
#    print(count * word)

#DublicateWords(5, "$")
#DublicateWords(10)





#def DublicateWords(count, word = "*", isHorizontal = True):
#    word += "" if isHorizontal else "\n"
#    print(count * word)

#DublicateWords(5, "test", False)
#DublicateWords(5, "test")
#DublicateWords(5)