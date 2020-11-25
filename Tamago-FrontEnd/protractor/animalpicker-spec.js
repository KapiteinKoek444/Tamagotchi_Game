const { browser, element } = require("protractor");

describe('Check login in page', function () {



  beforeEach(function () {
    browser.get('http://localhost:4200/#/animalpicker');
    nameField = element(by.id('nameInput'));

  });

  it('should create animal1 with name', async function () {

    nameField.sendKeys("test");

    animal = element(by.id('0'));

    animal.click();


    browser.waitForAngular();


    var EC = protractor.ExpectedConditions;
    // Wait for new page url to contain efg
    browser.wait(EC.urlContains('dashboard'), 1000);

  });

  it('should not create animal1 with no name', async function () {

    nameField.sendKeys("");

    animal = element(by.id('0'));

    animal.click();


    browser.waitForAngular();


    var EC = protractor.ExpectedConditions;
    // Wait for new page url to contain efg
    browser.wait(expect(browser.getCurrentUrl())
    .not
    .toBe('http://localhost:4200/#/dashboard'), 1000);
  });

  it('should create animal2 with name', async function () {

    nameField.sendKeys("test");

    animal = element(by.id('1'));

    animal.click();


    browser.waitForAngular();


    var EC = protractor.ExpectedConditions;
    // Wait for new page url to contain efg
    browser.wait(EC.urlContains('dashboard'), 1000);

  });
 
  it('should not create animal2 with no name', async function () {

    nameField.sendKeys("");

    animal = element(by.id('1'));

    animal.click();


    browser.waitForAngular();


    var EC = protractor.ExpectedConditions;
    // Wait for new page url to contain efg
    browser.wait(expect(browser.getCurrentUrl())
    .not
    .toBe('http://localhost:4200/#/dashboard'), 1000);
  });

  it('should create animal3 with name', async function () {

    nameField.sendKeys("test");

    animal = element(by.id('2'));

    animal.click();


    browser.waitForAngular();


    var EC = protractor.ExpectedConditions;
    // Wait for new page url to contain efg
    browser.wait(EC.urlContains('dashboard'), 1000);

  });

  it('should not create animal3 with no name', async function () {

    nameField.sendKeys("");

    animal = element(by.id('2'));

    animal.click();


    browser.waitForAngular();


    var EC = protractor.ExpectedConditions;
    // Wait for new page url to contain efg
    browser.wait(expect(browser.getCurrentUrl())
    .not
    .toBe('http://localhost:4200/#/dashboard'), 1000);
  });

  it('should create animal4 with name', async function () {

    nameField.sendKeys("test");

    animal = element(by.id('3'));

    animal.click();


    browser.waitForAngular();


    var EC = protractor.ExpectedConditions;
    // Wait for new page url to contain efg
    browser.wait(EC.urlContains('dashboard'), 1000);

  });

  it('should not create animal4 with no name', async function () {

    nameField.sendKeys("");

    animal = element(by.id('4'));

    animal.click();


    browser.waitForAngular();


    var EC = protractor.ExpectedConditions;
    // Wait for new page url to contain efg
    browser.wait(expect(browser.getCurrentUrl())
    .not
    .toBe('http://localhost:4200/#/dashboard'), 1000);
  });

  it('should create animal5 with name', async function () {

    nameField.sendKeys("test");

    animal = element(by.id('4'));

    animal.click();


    browser.waitForAngular();


    var EC = protractor.ExpectedConditions;
    // Wait for new page url to contain efg
    browser.wait(EC.urlContains('dashboard'), 1000);

  });

  it('should not create animal5 with no name', async function () {

    nameField.sendKeys("");

    animal = element(by.id('4'));

    animal.click();


    browser.waitForAngular();


    var EC = protractor.ExpectedConditions;
    // Wait for new page url to contain efg
    browser.wait(expect(browser.getCurrentUrl())
    .not
    .toBe('http://localhost:4200/#/dashboard'), 1000);
  });
});

