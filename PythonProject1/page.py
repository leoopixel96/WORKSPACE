import tkinter
import controller
import element


from tkinter import *


class Page:
    def newPage():
        root = Tk()
        root.geometry("200x150")
        frame = Frame(root)
        frame.pack()

        leftframe = Frame(root)
        leftframe.pack(side=LEFT)

        rightframe = Frame(root)
        rightframe.pack(side=RIGHT)

        label = Label(frame, text="Page")
        label.pack()

        root.title("Test")
        root.mainloop()
