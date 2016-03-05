from numpy import matrix
from numpy import linalg

# Assume the voltage at A is 1v, at B is 0v
Va = 1
Vb = 0

# Assign resistances  
R1 = 100
R2 = 100
R3 = 100
R4 = 200
R5 = 200


# The voltage at the conjunction of R1/R2/R5 is V1
# The voltage at the conjunction of R2/R3/R4 is V2
# The current from A to V1 is I1
# The current from V1 to V2 is I2
# The current from V2 to B is I3
# The current from A to V2 is I4
# The current from V1 to B is I5

#             V1  V2  I1  I2   I3   I4 I5   
A = matrix([[  1,  0, R1,  0,   0,  0, 0  ],   # V1 + I1R1 = Va
            [  1, -1,  0,-R2,   0,  0, 0  ],   # V1 - I2R2 = V2
			[  0,  1,  0,  0, -R3,  0, 0  ],   # V2 - I3R3 = Vb
			[  0,  1,  0,  0,   0, R4, 0  ],   # Va - I4R4 = V2 
			[  1,  0,  0,  0,   0,  0, -R5],   # V1 - I5R5 = Vb
			[  0,  0,  1, -1,   0,  0, -1 ],   # I1 = I2 + I5
			[  0,  0,  0,  1,  -1,  1, 0  ] ]) # I2 + I4 = I3
			 
y = matrix( [[Va, 0,Vb,Va,Vb,0,0]] )      

# The inverse of the Matrix A
inverse = linalg.inv(A)

# The solution 
sol = inverse.dot(y.T)

# The effective resistance equals to U/I = (Va - Vb ) / (I1+I4)
resis = (Va-Vb)/ (sol[2] + sol[5]);
print("The equivalent resistance is: " + str(resis.item(0)) +" Ohm." )
 