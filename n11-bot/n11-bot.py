from user import email,password
from selenium import webdriver
from selenium.webdriver.common.keys import Keys
from time import sleep

class N11:
    def __init__(self,email,password):
        self.email = email
        self.password = password
        self.browser = webdriver.Chrome("chromedriver.exe")

    def signIn(self):
        browser = self.browser
        self.browser.get("https://www.n11.com/")

        sleep(2)

        applyButton = self.browser.find_element_by_xpath('//*[@id="userKvkkModal"]/div/div[2]/span')
        applyButton.click()
        loginLabel = self.browser.find_element_by_xpath('//*[@id="header"]/div/div/div[2]/div[2]/div[2]/div/div/a[1]')
        loginLabel.click()
        faceButton = self.browser.find_element_by_xpath('//*[@id="loginContainer"]/div/div[1]/div/div[3]')
        faceButton.click()

        sleep(2)
        
        facebookLoginPage = browser.window_handles[1]
        browser.switch_to_window(facebookLoginPage)
        emailInput = self.browser.find_element_by_xpath('//*[@id="email"]')
        passwordInput = self.browser.find_element_by_xpath('//*[@id="pass"]')
        emailInput.send_keys(self.email)
        passwordInput.send_keys(self.password)
        loginbtn = self.browser.find_element_by_xpath('//*[@id="u_0_0"]')
        loginbtn.click()

        sleep(5)

    def search(self,word):
        browser = self.browser
        mainPage = self.browser.window_handles[0]
        browser.switch_to.window(mainPage)
        searchInput = self.browser.find_element_by_xpath('//*[@id="searchData"]')
        searchButton = self.browser.find_element_by_xpath('//*[@id="header"]/div/div/div[2]/div[1]/a/span')
        searchInput.send_keys(word)
        searchButton.click()

bot = N11(email,password)
bot.signIn()
bot.search("SAMSUNG")
