from tkinter import*
from tkinter import messagebox
window = Tk()
window.title("the watch")
##start the watch 
cliked=False
def start_time(S,M,H):
    global cliked
    cliked=True
    while cliked==True:
        import time
        S["text"]=S["text"]+1
        time.sleep(1)
        window.update()
        next_minute=check_next_minute(S,M)
        if next_minute:
            next_Hour=check_next_Hour(S,M,H)
            if next_Hour:
                next_day=check_next_day(S,M,H)
                if next_day:
                    H["text"]=0
                    M["text"]=0
                    S["text"]=-1  
def check_next_minute(S,M):
    if S["text"]==59:
        M["text"]+=1
        S["text"]=-1
        return True
    else:
        return False
def check_next_Hour(S,M,H):
    if M["text"]==60:
        H["text"]+=1
        M["text"]=0
        S["text"]=-1
        return True
    else: 
        return False
def check_next_day(S,M,H):
    if H["text"]>23:
        H["text"]=0
        M["text"]=0
        S["text"]=-1 
        return True
    else:
        return False
## reset the watch 
def reset(S,M,H):
    global cliked
    cliked=False
    S["text"]=0
    M["text"]=0
    H["text"]=0


## creat the buttons
def create_buttons():
    buttons_list=[]
    hours_button=Button(window,text=0, height=4, width=8, bg='#BEB8B7', fg="black")
    two_points_button=Button(window,text=":", height=4, width=2, bg='#BEB8B7', fg="black")
    minutes_button=Button(window,text=0, height=4, width=8, bg='#BEB8B7', fg="black")
    second_two_points_button=Button(window,text=":", height=4, width=2, bg='#BEB8B7', fg="black")
    seconds_button=Button(window,text=0, height=4, width=8, bg='#BEB8B7', fg="black")
    start_button=Button(window, text="start", height=4, width=8, bg='#BEB8B7', fg="black", 
    command=lambda: start_time(seconds_button,minutes_button,hours_button))
    reset_button=Button(window, text="reset", height=4, width=8, bg='#BEB8B7', fg="black", 
    command=lambda: reset(seconds_button,minutes_button,hours_button))
    buttons_list.extend([hours_button,two_points_button,minutes_button,
    second_two_points_button,seconds_button,start_button,reset_button])
    return buttons_list
def grid_buttons():
    row=0
    column=0
    buttons_list=create_buttons()
    for button in buttons_list:
        button.grid(row=row,column=column)
        column+=1
        if column==5:
            column=4
            row+=1
grid_buttons()
window.mainloop()
