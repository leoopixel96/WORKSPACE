import tkinter
import page

from tkinter import *

root = Tk()
root.geometry("200x150")
frame = Frame(root)
frame.pack()

leftframe = Frame(root)
leftframe.pack(side=LEFT)

rightframe = Frame(root)
rightframe.pack(side=RIGHT)

label = Label(frame, text="Dashboard")
label.pack()

button1 = Button(leftframe, text="Add Element", command=page.Page.newPage)
button1.pack(anchor="n")

root.title("Test")
root.mainloop()
