# # This code contains type errors
# def add_numbers(a, b):
#     return a + b

# result = add_numbers("hello", 5)
# print(result)

global_var = 10

def change_var():
    #global global_var
    global_var = 20

change_var()
print(global_var)  # Outputs: 10 without 'global' keyword, 20 with it