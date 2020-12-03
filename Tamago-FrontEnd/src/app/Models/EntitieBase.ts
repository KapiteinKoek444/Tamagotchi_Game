export class EntitieBase {

    public fromJSON(json) {
        for (var propName in json)
          this[propName] = json[propName];
        return this;
    }
}
