"use strict";
class Database {
    constructor() {
        console.log("nesne �retildi");
    }
    static get getInstance() {
        if (this._database == null) {
            this._database = new Database();
        }
        return this._database;
    }
}
var d1 = Database.getInstance;
console.log(d1);
//# sourceMappingURL=app.js.map