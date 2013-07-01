var Class = (function () {
	'use strict';
    function createClass(properties) {
        var createFunction = function () {
            this.init.apply(this, arguments);
        },
			prop;

        for (prop in properties) {
            createFunction.prototype[prop] = properties[prop];
        }
        if (!createFunction.prototype.init) {
            createFunction.prototype.init = function () {};
        }
        return createFunction;
    }

    Function.prototype.inherit = function (parent) {
        var oldPrototype = this.prototype,
			parentPrototype = new parent(),
			prop;
        this.prototype = Object.create(parentPrototype);
        this.prototype._super = parent;
        for (prop in oldPrototype) {
            this.prototype[prop] = oldPrototype[prop];
        }
    }

    return {
        create: createClass
    };
}());