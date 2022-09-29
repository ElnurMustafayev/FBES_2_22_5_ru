#try - except

#print("Start")

#try:
#    num = int(input("Number: "))
#    print(123 / num)
#    print(num)
#except ZeroDivisionError as error:
#    print("Num can not be zero!")
#    print(error)
#except ValueError as ex:
#    print("Incorrect data!")
#    print(ex)

#print("End")





#def InfRecursion(num):
#    num = int(input())
#    InfRecursion(123 / num)

#try:
#    InfRecursion(123)
#except RecursionError as error:
#    print(error)
#except ValueError as error:
#    print(error)
#except Exception as error:
#    print(type(error))
#    print(f"Default Error: {error}")



#def InputUserAge():
#    try:
#        age = int(input("Age: "))
#        return age >= 18
#    except Exception as ex:
#        print(ex)
#        return False


#print(InputUserAge())




#def PrintAllElements(arr):
#    counter = 0

#    while True:
#        try:
#            print(arr[counter])
#            counter += 1
#        except:
#            break


#nums = [1,2,3]
#PrintAllElements(nums)



#def InnerFunc():
#    try:
#        return 100 / 0
#    except Exception as ex:
#        print("3 level error")


#def Func():
#    try:
#        return InnerFunc()
#    except Exception as ex:
#        print("2 level error")

#try:
#    Func()
#except Exception as ex:
#    print("1 level error")





#print("Start")

#try:
#    print(100 / 0)
#except Exception as ex:
#    print(ex)
#    try:
#        ex.test()
#    except:
#        print("Error in except block")

#print("End")







#try:
#    nums = [1,2,3,4]
#    nums.append(123)

#    try:
#        if(nums.__contains__(3)):
#            nums.remove(5)
#    except:
#        print("Couldn't remove element '5'!")

#    nums.clear()
#    print(nums[3])
#except Exception as ex:
#    print(ex)


#successLogin = "qwerty"
#successPassword = "12345"


#def Login():
#    try:
#        print("Start")
#        login = input("Login: ")
#        password = input("Password: ")
#        code = int(input("OTP Code: "))

#        if(login != successLogin or password != successPassword):
#            raise Exception("Invalid credentials!")
#            #print(100 / 0)
#        else:
#            return True
#    except Exception as ex:
#        print(ex)
#        #if type(ex) == ZeroDivisionError:
#        #    print("Invalid credentials!")
#        #else:
#        #    print(f"Error: {ex}")

#        return False


#print(Login())





#def Div(a, b):
#    if(b == 0):
#        error = ZeroDivisionError("Hey, you! Stop it! B is 0!")
#        raise error

#    return a / b


#try:
#    print(Div(1, 0))
#except ZeroDivisionError as ex:
#    print(f"Critical error: {ex}")
#except Exception as ex:
#    print(ex)





#Registration()

#name, surname, age




#def Registration():
#    #NAME & SURNAME
#    name = input("Name: ")
#    surname = input("Surname: ")

#    areAlpha = name.isalpha() and surname.isalpha()
#    areCapitalized = (name == name.capitalize()) and (surname == surname.capitalize())

#    if not(areAlpha and areCapitalized):
#        raise ValueError("Incorrect name or surname!")

#    #AGE
#    ageStr = input("Age: ")

#    if not(ageStr.replace("-", "").isdigit()):
#        raise ValueError("Age is not digit!")

#    age = int(ageStr)

#    if age < 0:
#        raise ValueError("Age can not be less than 0!")
#    if age < 18:
#        raise Exception("Access denied!")



#try:
#    Registration()
#except Exception as ex:
#    print(f"{type(ex)}: {ex}")





#def Func():
#    try:
#        print(100 / 0)
#    except Exception as ex:
#        print(f"{type(ex)}: {ex}")
#        raise ex

#print("start")
#try:
#    Func()
#except Exception as ex:
#    print(f"{type(ex)}: {ex}")
#print("end")






#arr1 = [1,2,3]

#arr2 = arr1.copy()

#arr2.append(5)

#print(arr1)
#print(arr2)