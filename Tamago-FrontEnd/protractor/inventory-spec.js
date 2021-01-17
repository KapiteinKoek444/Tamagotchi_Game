const { not } = require("@angular/compiler/src/output/output_ast");
const { browser } = require("protractor");

describe('Check invertory in page', function () {


  beforeEach(function () {
    browser.get('http://localhost:4200/#/InventoryPage');

  });

//  it('is possible to use inventory items', async function () {

//     browser.get('http://localhost:4200/#/ShopPage');

//     var shopButton = element(by.id('Schultenbräu'));
//     shopButton.click();

//     var acceptButton = element(by.id('accept'));
//     acceptButton.click();

//     browser.get('http://localhost:4200/#/InventoryPage');

//     var iventoryItem = element(by.id('Schultenbräu'));
//     iventoryItem.click();

//     expect(element(by.id('Schultenbräu') == null));
//   });


  it('should load the users invertory', async function () {
    var EC = protractor.ExpectedConditions;
    browser.wait(EC.urlContains('InventoryPage'), 5000);
    expect(browser.getCurrentUrl())
      .toBe('http://localhost:4200/#/InventoryPage');
  });


});