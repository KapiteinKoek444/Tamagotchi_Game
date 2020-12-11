const { not } = require("@angular/compiler/src/output/output_ast");
const { browser } = require("protractor");

describe('Check sleep in page', function () {


  beforeEach(function () {
    browser.get('http://localhost:4200/#/SleepPage');

  });


  it('should load the sleep page', async function () {
    var EC = protractor.ExpectedConditions;
    browser.wait(EC.urlContains('SleepPage'), 5000);

    expect(browser.getCurrentUrl())
      .toBe('http://localhost:4200/#/SleepPage');
  });


});