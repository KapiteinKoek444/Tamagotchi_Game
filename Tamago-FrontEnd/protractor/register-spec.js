const { not } = require("@angular/compiler/src/output/output_ast");
const { browser } = require("protractor");

describe('Check register in page', function () {


  beforeEach(function () {
    browser.get('http://localhost:4200/#/register');
    emailField = element(by.id('emailField'));
    passwordField = element(by.id('passwordField'));
    registerButton = element(by.id('registerButton'));
  });


  it('should not be eable to register with already existing acount', async function () {
    emailField.sendKeys("testditplz@test.be");
    passwordField.sendKeys("test123");


    registerButton.click();

    registerButton.click();

    browser.waitForAngular();


    var EC = protractor.ExpectedConditions;
    // Wait for new page url to contain efg
    browser.wait(  expect(browser.getCurrentUrl())
    .not.toBe('http://localhost:4200/#/animalpicker'), 3000);


  });


});