const { browser, element } = require("protractor");


describe('Check login in page', function () {

    beforeEach(function () {
        browser.get('http://localhost:4200/#/dashboard');
    });

    it('should be 0 the food status', async function () {
        food = element(by.id('foodStatus'));
        expect(food.getText()).toEqual('Food: 100');

    });

    it('should be 0 the energy status', async function () {
        food = element(by.id('energyStatus'));
        expect(food.getText()).toEqual('Energy: 100');

    });

    it('should be 0 the happiness status', async function () {
        food = element(by.id('happinessStatus'));
        expect(food.getText()).toEqual('Happiness: 100');
    });

    it('should navigate to games-page when playbutton is pressed', async function () {
        food = element(by.id('button_2'));

        var EC = protractor.ExpectedConditions;
        // Wait for new page url to contain efg
        browser.wait(  expect(browser.getCurrentUrl())
        .not.toBe('http://localhost:4200/#/gamepage'), 2000);
    });

    it('should navigate to shop-page when shopbutton is pressed', async function () {
        food = element(by.id('button_4'));
        var EC = protractor.ExpectedConditions;
        // Wait for new page url to contain efg
        browser.wait(  expect(browser.getCurrentUrl())
        .not.toBe('http://localhost:4200/#/shoppage'), 2000);
    });

});