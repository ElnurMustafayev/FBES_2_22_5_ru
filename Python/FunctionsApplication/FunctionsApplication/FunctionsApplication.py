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