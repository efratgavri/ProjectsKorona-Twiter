
def print_triangle(width,height):

    cnt=3
    print(" " * ((width - 1) // 2) + "*")
    odd=((width-2)//2)
    row=((height-2)//odd)
    plus=((height-2)%odd)
    if plus!=0:

        for k in range ((plus)):
            print(" " * (((width - 1) // 2)-1)+"*" * cnt)

    for i in range(odd):
      for j in range(row):
        print(" " * (((width - 1) // 2)-(i+1))+"*" * cnt)

      cnt+=2
    print("*" * width)



def print_menu():
 print("ברוך הבא לתפריט!")
 print("אנא בחר את האופציה המתאימה לך:")
 print("1. בחירת מגדל מלבן")
 print("2. בחירת מגדל משולש")
 print("3. יציאה מהתוכנית")

print_menu()
user_choice = ""
user_choice = input("אנא הכנס את מספר האופציה המבוקשת: ")



    # השורה הבאה תראה את התפריט למשתמש בלולאה כל עוד הוא לא בחר לצאת

while user_choice != "3":


    if user_choice=="1":
        len = int(input("Enter lenghs of triangle: "))
        width = int(input("Enter width of triangle: "))  # קליטת רוחב המשולש מהמשתמש
        if  abs(len - width)>5:
            print(len*width)
        else:
            print(len*2+width*2)


    if user_choice=="2":
        width = int(input("Enter the width of the triangle (must be an odd number): "))
        height = int(input("Enter the height of the triangle: "))
        print("1. חישוב היקף משולש")
        print("2. הדפסת משולש")
        choice=""
        choice = input("אנא הכנס את מספר האופציה המבוקשת: ")
        if choice=="1":
            print((height*2)+width)
        elif choice=="2":
            if width%2==0 or width>=(height*2):
                print("error")
            else:
               print_triangle(width, height)
    print_menu()
    user_choice = input("אנא הכנס את מספר האופציה המבוקשת: ")


