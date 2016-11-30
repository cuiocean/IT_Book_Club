from enum import Enum

class TriangleType(Enum):
    Scalene = 0,
    Isosceles = 1,
    Equilateral = 2,
    Invalid = 3


def TriangleTypeCheck(side1, side2, side3):
    if side1 <= 0.0 or side2 <= 0.0 or side3 <= 0.0:
        return TriangleType.Invalid
    if side1+side2 <=side3 or side1+side3<=side2 or side2+side3<side1:
        return TriangleType.Invalid
    if side1 == side2 and side1 == side3:
        return TriangleType.Equilateral
    if side1 == side2 or side1 == side3 or side2 == side3 :
        return TriangleType.Isosceles
    return TriangleType.Scalene
