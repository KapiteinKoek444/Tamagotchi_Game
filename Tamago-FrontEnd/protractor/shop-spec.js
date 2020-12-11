const { not } = require("@angular/compiler/src/output/output_ast");
const { browser } = require("protractor");

describe('Check Shop in page', function () {


  beforeEach(function () {
    browser.get('http://localhost:4200/#/ShopPage');

  });


  it('should load the Shop Page', async function () {
    var EC = protractor.ExpectedConditions;
    browser.wait(EC.urlContains('ShopPage'), 5000);

    expect(browser.getCurrentUrl())
      .toBe('http://localhost:4200/#/ShopPage');
  });

});