import unittest
from TriangleTypeCheck import TriangleTypeCheck
from TriangleTypeCheck import TriangleType

class TestTriangleTypeCheck(unittest.TestCase):
    def setUp(self):
        pass
    def test_length_3_4_5(self):
        self.assertEqual( TriangleTypeCheck(3,4,5),  TriangleType.Scalene)

if __name__ == '__main__':
    unittest.main()