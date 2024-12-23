# test_main.py

import unittest
from main import Computer, DisplayClass, ComputerDisplay, computers_with_a_display, display_classes_with_max_price, all_related_computers_and_display_classes

class TestComputerDisplayMethods(unittest.TestCase):

    def setUp(self):
        self.computers = [
            Computer(1, 'Dell XPS', 1200),
            Computer(2, 'Apple MacBook', 2400),
            Computer(3, 'Lenovo ThinkPad', 900),
            Computer(4, 'Asus ROG', 1500),
        ]
        self.display_classes = [
            DisplayClass(1, 'Advanced Display Technology'),
            DisplayClass(2, 'Basic Display Package'),
            DisplayClass(3, 'Advanced Display Tech'),
        ]
        self.computer_displays = [
            ComputerDisplay(1, 1),
            ComputerDisplay(2, 2),
            ComputerDisplay(3, 1),
            ComputerDisplay(4, 3),
            ComputerDisplay(3, 2),
        ]

    def test_computers_with_a_display(self):
        result = computers_with_a_display(self.display_classes, self.computers, self.computer_displays)
        expected = [
            ('Advanced Display Technology', ['Dell XPS', 'Lenovo ThinkPad']),
            ('Advanced Display Tech', ['Asus ROG'])
        ]
        self.assertEqual(result, expected)

    def test_display_classes_with_max_price(self):
        result = display_classes_with_max_price(self.display_classes, self.computers, self.computer_displays)
        expected = [
            ('Basic Display Package', 2400),
            ('Advanced Display Tech', 1500),
            ('Advanced Display Technology', 1200)
        ]
        self.assertEqual(result, expected)

    def test_all_related_computers_and_display_classes(self):
        result = all_related_computers_and_display_classes(self.display_classes, self.computers, self.computer_displays)
        expected = [
            ('Компьютер: Apple MacBook', 'Дисплейный класс: Basic Display Package'),
            ('Компьютер: Lenovo ThinkPad', 'Дисплейный класс: Basic Display Package'),
            ('Компьютер: Dell XPS', 'Дисплейный класс: Advanced Display Technology'),
            ('Компьютер: Lenovo ThinkPad', 'Дисплейный класс: Advanced Display Technology'),
            ('Компьютер: Asus ROG', 'Дисплейный класс: Advanced Display Tech')
        ]
        self.assertEqual(result, expected)

if __name__ == '__main__':
    unittest.main()
