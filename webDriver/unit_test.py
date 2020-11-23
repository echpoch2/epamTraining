import unittest
from selenium.webdriver import Opera
from selenium.webdriver.opera.options import Options

class CartTest(unittest.TestCase):
    def test_cartCost(self):
        opts = Options()
        opts.headless = True
        assert opts.headless  # без графического интерфейса.
        browser = Opera(options=opts)

        browser.get('https://luch.by/kollektsii/volat-2-0/728377624/')
        item1Price = int(browser.find_element_by_class_name('styled-price').text[:-4])
        browser.find_element_by_class_name('button_add').click()

        browser.get('https://luch.by/kollektsii/classic/76730567/')
        item2Price = int(browser.find_element_by_class_name('styled-price').text[:-4])
        browser.find_element_by_class_name('button_add').click()

        browser.get('https://luch.by/cart/')
        total = int(browser.find_element_by_class_name('styled-price').text[:-4])
        self.assertEqual(total, item1Price+item2Price)


if __name__ == '__main__':
    unittest.main()
