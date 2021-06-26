from selenium import webdriver
from selenium.webdriver.common.by import By
from selenium.webdriver.support.ui import WebDriverWait
from selenium.webdriver.support import expected_conditions as ec
import time


chrome_options = webdriver.ChromeOptions()
prefs = {
	"profile.managed_default_content_settings.images":1
}
chrome_options.add_experimental_option("prefs", prefs)
driver = webdriver.Chrome('./chromedriver', options = chrome_options)

driver.get('https://youtube.com')

bien=driver.find_element_by_css_selector('input[name="search_query"')
bien.send_keys("Mr Siro")

time.sleep(3)

click=driver.find_element_by_css_selector('button[id="search-icon-legacy"')
click.click()
time.sleep(6)

play_else = driver.find_element_by_css_selector('ytd-video-renderer[class="style-scope ytd-item-section-renderer"')
play_else.click()

