export class BuyBleModel {
    public itemId: string;
    public userId: string;

    constructor(itemId: string, userId: string){
        this.itemId = itemId;
        this.userId = userId;
    }
}