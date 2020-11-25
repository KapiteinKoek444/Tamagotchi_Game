const { browser } = require("protractor");

describe('Check login in page', function () {

  var emailField;
  var passwordField;
  var loginButton;

  beforeEach(function () {
    browser.get('http://localhost:4200/#/login');
    emailField = element(by.id('emailField'));
    passwordField = element(by.id('passwordField'));
    loginButton = element(by.id('loginButton'));
    registerButton = element(by.id('registerButton'));

  });

  it('should be eable to login in', async function () {
    emailField.sendKeys("testditplz@test.be");
    passwordField.sendKeys("test123");


    loginButton.click();


    loginButton.click();

    browser.waitForAngular();


    var EC = protractor.ExpectedConditions;
    // Wait for new page url to contain efg
    browser.wait(EC.urlContains('dashboard'), 10000);


    expect(browser.getCurrentUrl())
      .toBe('http://localhost:4200/#/dashboard');

  });

  it('should be eable to register in', async function () {

    registerButton.click();


    browser.waitForAngular();


    var EC = protractor.ExpectedConditions;
    // Wait for new page url to contain efg
    browser.wait(EC.urlContains('register'), 10000);


    expect(browser.getCurrentUrl())
      .toBe('http://localhost:4200/#/register');

  });

});




