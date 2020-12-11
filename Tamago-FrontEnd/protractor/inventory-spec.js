const { not } = require("@angular/compiler/src/output/output_ast");
const { browser } = require("protractor");

describe('Check invertory in page', function () {


  beforeEach(function () {
    browser.get('http://localhost:4200/#/InventoryPage');

  });


  it('should load the users invertory', async function () {
    var EC = protractor.ExpectedConditions;
    browser.wait(EC.urlContains('InventoryPage'), 5000);
    expect(browser.getCurrentUrl())
      .toBe('http://localhost:4200/#/InventoryPage');
  });


});