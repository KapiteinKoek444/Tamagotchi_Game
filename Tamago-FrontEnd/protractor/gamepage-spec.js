const { browser, element } = require("protractor");

describe('Check gamepage in page', function () {

    beforeEach(function () {
        browser.get('http://localhost:4200/#/GamesPage');
        browser.waitForAngular();
    });

    // it('should be able to earn money by playing game', async function () {

    //     browser.get('http://localhost:4200/#/InventoryPage');wallet

    //     var walletBegin = element(by.id('wallet'));
    //     var valueBegin =parseFloat(walletBegin.getText());

    //     browser.get('http://localhost:4200/#/GamesPage');

    //     var urlCaller = element(by.id('urlCaller0'));
    //     urlCaller.click();

    //     browser.get('http://localhost:4200/#/InventoryPage');wallet

    //     var walletEnd = element(by.id('wallet'));
    //     var valueEnd = parseFloat(walletEnd.getText());

    //     expect(valueBegin < valueEnd);
    // });

    it('should be 0 index name card', async function () {
        urlCaller = element(by.id('urlCaller0'));
        card           = element(by.id('card0'));

        expect(card.getText()).toEqual("Tetris");
    });
    
    it('should be 1 index name card', async function () {
        urlCaller = element(by.id('urlCaller1'));
        card           = element(by.id('card1'));

        expect(card.getText()).toEqual("Memory");
    });
    
    it('should be 2 index name card', async function () {
        urlCaller = element(by.id('urlCaller2'));
        card           = element(by.id('card2'));

        expect(card.getText()).toEqual( "Game 3");
    });
    
    it('should be 3 index name card', async function () {
        urlCaller = element(by.id('urlCaller3'));
        card           = element(by.id('card3'));

        expect(card.getText()).toEqual( "Game 4");
    });
    
    it('should be 4 index name card', async function () {
        urlCaller = element(by.id('urlCaller4'));
        card           = element(by.id('card4'));

        expect(card.getText()).toEqual( "Game 5");
    });

    it('should be 5 index name card', async function () {
        urlCaller = element(by.id('urlCaller5'));
        card           = element(by.id('card5'));

        expect(card.getText()).toEqual( "Game 6");
    });

    it('should be 6 index name card', async function () {
        urlCaller = element(by.id('urlCaller6'));
        card           = element(by.id('card6'));

        expect(card.getText()).toEqual( "Game 7");
    });

    it('should be 7 index name card', async function () {
        urlCaller = element(by.id('urlCaller7'));
        card           = element(by.id('card7'));

        expect(card.getText()).toEqual( "Game 8");
    });
    
    it('should be 8 index name card', async function () {
        urlCaller = element(by.id('urlCaller8'));
        card           = element(by.id('card8'));

        expect(card.getText()).toEqual( "Game 9");
    });
    
    it('should be 9 index name card', async function () {
        urlCaller = element(by.id('urlCaller9'));
        card           = element(by.id('card9'));

        expect(card.getText()).toEqual( "Game 10");
    });
    
    
});