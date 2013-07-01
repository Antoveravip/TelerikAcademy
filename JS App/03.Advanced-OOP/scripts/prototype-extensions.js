if (!Object.create) {
    Object.create = function (obj) {
		'use strict';
        function CreateObject() {}
        CreateObject.prototype = obj;
        return new CreateObject();
    };
}
if (!Object.prototype.extend) {
    Object.prototype.extend = function (properties) {
		'use strict';
        function CreateObject() {}
        CreateObject.prototype = Object.create(this);
        for (var prop in properties) {
            CreateObject.prototype[prop] = properties[prop];
        }
        CreateObject.prototype._super = this;
        return new CreateObject();
    };
}