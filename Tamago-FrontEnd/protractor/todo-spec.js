const { browser } = require("protractor");

describe('Check login in page',  function() {
  var emailField;
  var passwordField;
  var loginButton;

  beforeEach(function() {
    browser.get('http://localhost:4200/#/login');
    emailField = element(by.id('emailField'));
    passwordField = element(by.id('passwordField'));
    loginButton = element(by.id('loginButton'));

  });

  it('should add one and two', async function() {
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

});