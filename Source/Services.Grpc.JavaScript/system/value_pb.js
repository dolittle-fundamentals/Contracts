/**
 * @fileoverview
 * @enhanceable
 * @suppress {messageConventions} JS Compiler reports an error if a variable or
 *     field starts with 'MSG_' and isn't a translatable message.
 * @public
 */
// GENERATED CODE -- DO NOT EDIT!

var jspb = require('google-protobuf');
var goog = jspb;
var global = Function('return this')();

var system_object_pb = require('../system/object_pb.js');
goog.object.extend(proto, system_object_pb);
goog.exportSymbol('proto.system.ArrayValue', null, global);
goog.exportSymbol('proto.system.DictionaryValue', null, global);
goog.exportSymbol('proto.system.Value', null, global);
/**
 * Generated by JsPbCodeGenerator.
 * @param {Array=} opt_data Optional initial data array, typically from a
 * server response, or constructed directly in Javascript. The array is used
 * in place and becomes part of the constructed object. It is not cloned.
 * If no data is provided, the constructed object will be empty, but still
 * valid.
 * @extends {jspb.Message}
 * @constructor
 */
proto.system.Value = function(opt_data) {
  jspb.Message.initialize(this, opt_data, 0, -1, null, proto.system.Value.oneofGroups_);
};
goog.inherits(proto.system.Value, jspb.Message);
if (goog.DEBUG && !COMPILED) {
  /**
   * @public
   * @override
   */
  proto.system.Value.displayName = 'proto.system.Value';
}
/**
 * Generated by JsPbCodeGenerator.
 * @param {Array=} opt_data Optional initial data array, typically from a
 * server response, or constructed directly in Javascript. The array is used
 * in place and becomes part of the constructed object. It is not cloned.
 * If no data is provided, the constructed object will be empty, but still
 * valid.
 * @extends {jspb.Message}
 * @constructor
 */
proto.system.ArrayValue = function(opt_data) {
  jspb.Message.initialize(this, opt_data, 0, -1, proto.system.ArrayValue.repeatedFields_, null);
};
goog.inherits(proto.system.ArrayValue, jspb.Message);
if (goog.DEBUG && !COMPILED) {
  /**
   * @public
   * @override
   */
  proto.system.ArrayValue.displayName = 'proto.system.ArrayValue';
}
/**
 * Generated by JsPbCodeGenerator.
 * @param {Array=} opt_data Optional initial data array, typically from a
 * server response, or constructed directly in Javascript. The array is used
 * in place and becomes part of the constructed object. It is not cloned.
 * If no data is provided, the constructed object will be empty, but still
 * valid.
 * @extends {jspb.Message}
 * @constructor
 */
proto.system.DictionaryValue = function(opt_data) {
  jspb.Message.initialize(this, opt_data, 0, -1, null, null);
};
goog.inherits(proto.system.DictionaryValue, jspb.Message);
if (goog.DEBUG && !COMPILED) {
  /**
   * @public
   * @override
   */
  proto.system.DictionaryValue.displayName = 'proto.system.DictionaryValue';
}

/**
 * Oneof group definitions for this message. Each group defines the field
 * numbers belonging to that group. When of these fields' value is set, all
 * other fields in the group are cleared. During deserialization, if multiple
 * fields are encountered for a group, only the last value seen will be kept.
 * @private {!Array<!Array<number>>}
 * @const
 */
proto.system.Value.oneofGroups_ = [[1,2,3]];

/**
 * @enum {number}
 */
proto.system.Value.KindCase = {
  KIND_NOT_SET: 0,
  OBJECT_VALUE: 1,
  LIST_VALUE: 2,
  DICTIONARY_VALUE: 3
};

/**
 * @return {proto.system.Value.KindCase}
 */
proto.system.Value.prototype.getKindCase = function() {
  return /** @type {proto.system.Value.KindCase} */(jspb.Message.computeOneofCase(this, proto.system.Value.oneofGroups_[0]));
};



if (jspb.Message.GENERATE_TO_OBJECT) {
/**
 * Creates an object representation of this proto suitable for use in Soy templates.
 * Field names that are reserved in JavaScript and will be renamed to pb_name.
 * To access a reserved field use, foo.pb_<name>, eg, foo.pb_default.
 * For the list of reserved names please see:
 *     com.google.apps.jspb.JsClassTemplate.JS_RESERVED_WORDS.
 * @param {boolean=} opt_includeInstance Whether to include the JSPB instance
 *     for transitional soy proto support: http://goto/soy-param-migration
 * @return {!Object}
 */
proto.system.Value.prototype.toObject = function(opt_includeInstance) {
  return proto.system.Value.toObject(opt_includeInstance, this);
};


/**
 * Static version of the {@see toObject} method.
 * @param {boolean|undefined} includeInstance Whether to include the JSPB
 *     instance for transitional soy proto support:
 *     http://goto/soy-param-migration
 * @param {!proto.system.Value} msg The msg instance to transform.
 * @return {!Object}
 * @suppress {unusedLocalVariables} f is only used for nested messages
 */
proto.system.Value.toObject = function(includeInstance, msg) {
  var f, obj = {
    objectValue: (f = msg.getObjectValue()) && system_object_pb.Object.toObject(includeInstance, f),
    listValue: (f = msg.getListValue()) && proto.system.ArrayValue.toObject(includeInstance, f),
    dictionaryValue: (f = msg.getDictionaryValue()) && proto.system.DictionaryValue.toObject(includeInstance, f)
  };

  if (includeInstance) {
    obj.$jspbMessageInstance = msg;
  }
  return obj;
};
}


/**
 * Deserializes binary data (in protobuf wire format).
 * @param {jspb.ByteSource} bytes The bytes to deserialize.
 * @return {!proto.system.Value}
 */
proto.system.Value.deserializeBinary = function(bytes) {
  var reader = new jspb.BinaryReader(bytes);
  var msg = new proto.system.Value;
  return proto.system.Value.deserializeBinaryFromReader(msg, reader);
};


/**
 * Deserializes binary data (in protobuf wire format) from the
 * given reader into the given message object.
 * @param {!proto.system.Value} msg The message object to deserialize into.
 * @param {!jspb.BinaryReader} reader The BinaryReader to use.
 * @return {!proto.system.Value}
 */
proto.system.Value.deserializeBinaryFromReader = function(msg, reader) {
  while (reader.nextField()) {
    if (reader.isEndGroup()) {
      break;
    }
    var field = reader.getFieldNumber();
    switch (field) {
    case 1:
      var value = new system_object_pb.Object;
      reader.readMessage(value,system_object_pb.Object.deserializeBinaryFromReader);
      msg.setObjectValue(value);
      break;
    case 2:
      var value = new proto.system.ArrayValue;
      reader.readMessage(value,proto.system.ArrayValue.deserializeBinaryFromReader);
      msg.setListValue(value);
      break;
    case 3:
      var value = new proto.system.DictionaryValue;
      reader.readMessage(value,proto.system.DictionaryValue.deserializeBinaryFromReader);
      msg.setDictionaryValue(value);
      break;
    default:
      reader.skipField();
      break;
    }
  }
  return msg;
};


/**
 * Serializes the message to binary data (in protobuf wire format).
 * @return {!Uint8Array}
 */
proto.system.Value.prototype.serializeBinary = function() {
  var writer = new jspb.BinaryWriter();
  proto.system.Value.serializeBinaryToWriter(this, writer);
  return writer.getResultBuffer();
};


/**
 * Serializes the given message to binary data (in protobuf wire
 * format), writing to the given BinaryWriter.
 * @param {!proto.system.Value} message
 * @param {!jspb.BinaryWriter} writer
 * @suppress {unusedLocalVariables} f is only used for nested messages
 */
proto.system.Value.serializeBinaryToWriter = function(message, writer) {
  var f = undefined;
  f = message.getObjectValue();
  if (f != null) {
    writer.writeMessage(
      1,
      f,
      system_object_pb.Object.serializeBinaryToWriter
    );
  }
  f = message.getListValue();
  if (f != null) {
    writer.writeMessage(
      2,
      f,
      proto.system.ArrayValue.serializeBinaryToWriter
    );
  }
  f = message.getDictionaryValue();
  if (f != null) {
    writer.writeMessage(
      3,
      f,
      proto.system.DictionaryValue.serializeBinaryToWriter
    );
  }
};


/**
 * optional Object object_value = 1;
 * @return {?proto.system.Object}
 */
proto.system.Value.prototype.getObjectValue = function() {
  return /** @type{?proto.system.Object} */ (
    jspb.Message.getWrapperField(this, system_object_pb.Object, 1));
};


/** @param {?proto.system.Object|undefined} value */
proto.system.Value.prototype.setObjectValue = function(value) {
  jspb.Message.setOneofWrapperField(this, 1, proto.system.Value.oneofGroups_[0], value);
};


/**
 * Clears the message field making it undefined.
 */
proto.system.Value.prototype.clearObjectValue = function() {
  this.setObjectValue(undefined);
};


/**
 * Returns whether this field is set.
 * @return {boolean}
 */
proto.system.Value.prototype.hasObjectValue = function() {
  return jspb.Message.getField(this, 1) != null;
};


/**
 * optional ArrayValue list_value = 2;
 * @return {?proto.system.ArrayValue}
 */
proto.system.Value.prototype.getListValue = function() {
  return /** @type{?proto.system.ArrayValue} */ (
    jspb.Message.getWrapperField(this, proto.system.ArrayValue, 2));
};


/** @param {?proto.system.ArrayValue|undefined} value */
proto.system.Value.prototype.setListValue = function(value) {
  jspb.Message.setOneofWrapperField(this, 2, proto.system.Value.oneofGroups_[0], value);
};


/**
 * Clears the message field making it undefined.
 */
proto.system.Value.prototype.clearListValue = function() {
  this.setListValue(undefined);
};


/**
 * Returns whether this field is set.
 * @return {boolean}
 */
proto.system.Value.prototype.hasListValue = function() {
  return jspb.Message.getField(this, 2) != null;
};


/**
 * optional DictionaryValue dictionary_value = 3;
 * @return {?proto.system.DictionaryValue}
 */
proto.system.Value.prototype.getDictionaryValue = function() {
  return /** @type{?proto.system.DictionaryValue} */ (
    jspb.Message.getWrapperField(this, proto.system.DictionaryValue, 3));
};


/** @param {?proto.system.DictionaryValue|undefined} value */
proto.system.Value.prototype.setDictionaryValue = function(value) {
  jspb.Message.setOneofWrapperField(this, 3, proto.system.Value.oneofGroups_[0], value);
};


/**
 * Clears the message field making it undefined.
 */
proto.system.Value.prototype.clearDictionaryValue = function() {
  this.setDictionaryValue(undefined);
};


/**
 * Returns whether this field is set.
 * @return {boolean}
 */
proto.system.Value.prototype.hasDictionaryValue = function() {
  return jspb.Message.getField(this, 3) != null;
};



/**
 * List of repeated fields within this message type.
 * @private {!Array<number>}
 * @const
 */
proto.system.ArrayValue.repeatedFields_ = [1];



if (jspb.Message.GENERATE_TO_OBJECT) {
/**
 * Creates an object representation of this proto suitable for use in Soy templates.
 * Field names that are reserved in JavaScript and will be renamed to pb_name.
 * To access a reserved field use, foo.pb_<name>, eg, foo.pb_default.
 * For the list of reserved names please see:
 *     com.google.apps.jspb.JsClassTemplate.JS_RESERVED_WORDS.
 * @param {boolean=} opt_includeInstance Whether to include the JSPB instance
 *     for transitional soy proto support: http://goto/soy-param-migration
 * @return {!Object}
 */
proto.system.ArrayValue.prototype.toObject = function(opt_includeInstance) {
  return proto.system.ArrayValue.toObject(opt_includeInstance, this);
};


/**
 * Static version of the {@see toObject} method.
 * @param {boolean|undefined} includeInstance Whether to include the JSPB
 *     instance for transitional soy proto support:
 *     http://goto/soy-param-migration
 * @param {!proto.system.ArrayValue} msg The msg instance to transform.
 * @return {!Object}
 * @suppress {unusedLocalVariables} f is only used for nested messages
 */
proto.system.ArrayValue.toObject = function(includeInstance, msg) {
  var f, obj = {
    valuesList: jspb.Message.toObjectList(msg.getValuesList(),
    proto.system.Value.toObject, includeInstance)
  };

  if (includeInstance) {
    obj.$jspbMessageInstance = msg;
  }
  return obj;
};
}


/**
 * Deserializes binary data (in protobuf wire format).
 * @param {jspb.ByteSource} bytes The bytes to deserialize.
 * @return {!proto.system.ArrayValue}
 */
proto.system.ArrayValue.deserializeBinary = function(bytes) {
  var reader = new jspb.BinaryReader(bytes);
  var msg = new proto.system.ArrayValue;
  return proto.system.ArrayValue.deserializeBinaryFromReader(msg, reader);
};


/**
 * Deserializes binary data (in protobuf wire format) from the
 * given reader into the given message object.
 * @param {!proto.system.ArrayValue} msg The message object to deserialize into.
 * @param {!jspb.BinaryReader} reader The BinaryReader to use.
 * @return {!proto.system.ArrayValue}
 */
proto.system.ArrayValue.deserializeBinaryFromReader = function(msg, reader) {
  while (reader.nextField()) {
    if (reader.isEndGroup()) {
      break;
    }
    var field = reader.getFieldNumber();
    switch (field) {
    case 1:
      var value = new proto.system.Value;
      reader.readMessage(value,proto.system.Value.deserializeBinaryFromReader);
      msg.addValues(value);
      break;
    default:
      reader.skipField();
      break;
    }
  }
  return msg;
};


/**
 * Serializes the message to binary data (in protobuf wire format).
 * @return {!Uint8Array}
 */
proto.system.ArrayValue.prototype.serializeBinary = function() {
  var writer = new jspb.BinaryWriter();
  proto.system.ArrayValue.serializeBinaryToWriter(this, writer);
  return writer.getResultBuffer();
};


/**
 * Serializes the given message to binary data (in protobuf wire
 * format), writing to the given BinaryWriter.
 * @param {!proto.system.ArrayValue} message
 * @param {!jspb.BinaryWriter} writer
 * @suppress {unusedLocalVariables} f is only used for nested messages
 */
proto.system.ArrayValue.serializeBinaryToWriter = function(message, writer) {
  var f = undefined;
  f = message.getValuesList();
  if (f.length > 0) {
    writer.writeRepeatedMessage(
      1,
      f,
      proto.system.Value.serializeBinaryToWriter
    );
  }
};


/**
 * repeated Value values = 1;
 * @return {!Array<!proto.system.Value>}
 */
proto.system.ArrayValue.prototype.getValuesList = function() {
  return /** @type{!Array<!proto.system.Value>} */ (
    jspb.Message.getRepeatedWrapperField(this, proto.system.Value, 1));
};


/** @param {!Array<!proto.system.Value>} value */
proto.system.ArrayValue.prototype.setValuesList = function(value) {
  jspb.Message.setRepeatedWrapperField(this, 1, value);
};


/**
 * @param {!proto.system.Value=} opt_value
 * @param {number=} opt_index
 * @return {!proto.system.Value}
 */
proto.system.ArrayValue.prototype.addValues = function(opt_value, opt_index) {
  return jspb.Message.addToRepeatedWrapperField(this, 1, opt_value, proto.system.Value, opt_index);
};


/**
 * Clears the list making it empty but non-null.
 */
proto.system.ArrayValue.prototype.clearValuesList = function() {
  this.setValuesList([]);
};





if (jspb.Message.GENERATE_TO_OBJECT) {
/**
 * Creates an object representation of this proto suitable for use in Soy templates.
 * Field names that are reserved in JavaScript and will be renamed to pb_name.
 * To access a reserved field use, foo.pb_<name>, eg, foo.pb_default.
 * For the list of reserved names please see:
 *     com.google.apps.jspb.JsClassTemplate.JS_RESERVED_WORDS.
 * @param {boolean=} opt_includeInstance Whether to include the JSPB instance
 *     for transitional soy proto support: http://goto/soy-param-migration
 * @return {!Object}
 */
proto.system.DictionaryValue.prototype.toObject = function(opt_includeInstance) {
  return proto.system.DictionaryValue.toObject(opt_includeInstance, this);
};


/**
 * Static version of the {@see toObject} method.
 * @param {boolean|undefined} includeInstance Whether to include the JSPB
 *     instance for transitional soy proto support:
 *     http://goto/soy-param-migration
 * @param {!proto.system.DictionaryValue} msg The msg instance to transform.
 * @return {!Object}
 * @suppress {unusedLocalVariables} f is only used for nested messages
 */
proto.system.DictionaryValue.toObject = function(includeInstance, msg) {
  var f, obj = {
    objectMap: (f = msg.getObjectMap()) ? f.toObject(includeInstance, proto.system.Value.toObject) : []
  };

  if (includeInstance) {
    obj.$jspbMessageInstance = msg;
  }
  return obj;
};
}


/**
 * Deserializes binary data (in protobuf wire format).
 * @param {jspb.ByteSource} bytes The bytes to deserialize.
 * @return {!proto.system.DictionaryValue}
 */
proto.system.DictionaryValue.deserializeBinary = function(bytes) {
  var reader = new jspb.BinaryReader(bytes);
  var msg = new proto.system.DictionaryValue;
  return proto.system.DictionaryValue.deserializeBinaryFromReader(msg, reader);
};


/**
 * Deserializes binary data (in protobuf wire format) from the
 * given reader into the given message object.
 * @param {!proto.system.DictionaryValue} msg The message object to deserialize into.
 * @param {!jspb.BinaryReader} reader The BinaryReader to use.
 * @return {!proto.system.DictionaryValue}
 */
proto.system.DictionaryValue.deserializeBinaryFromReader = function(msg, reader) {
  while (reader.nextField()) {
    if (reader.isEndGroup()) {
      break;
    }
    var field = reader.getFieldNumber();
    switch (field) {
    case 1:
      var value = msg.getObjectMap();
      reader.readMessage(value, function(message, reader) {
        jspb.Map.deserializeBinary(message, reader, jspb.BinaryReader.prototype.readString, jspb.BinaryReader.prototype.readMessage, proto.system.Value.deserializeBinaryFromReader, "");
         });
      break;
    default:
      reader.skipField();
      break;
    }
  }
  return msg;
};


/**
 * Serializes the message to binary data (in protobuf wire format).
 * @return {!Uint8Array}
 */
proto.system.DictionaryValue.prototype.serializeBinary = function() {
  var writer = new jspb.BinaryWriter();
  proto.system.DictionaryValue.serializeBinaryToWriter(this, writer);
  return writer.getResultBuffer();
};


/**
 * Serializes the given message to binary data (in protobuf wire
 * format), writing to the given BinaryWriter.
 * @param {!proto.system.DictionaryValue} message
 * @param {!jspb.BinaryWriter} writer
 * @suppress {unusedLocalVariables} f is only used for nested messages
 */
proto.system.DictionaryValue.serializeBinaryToWriter = function(message, writer) {
  var f = undefined;
  f = message.getObjectMap(true);
  if (f && f.getLength() > 0) {
    f.serializeBinary(1, writer, jspb.BinaryWriter.prototype.writeString, jspb.BinaryWriter.prototype.writeMessage, proto.system.Value.serializeBinaryToWriter);
  }
};


/**
 * map<string, Value> object = 1;
 * @param {boolean=} opt_noLazyCreate Do not create the map if
 * empty, instead returning `undefined`
 * @return {!jspb.Map<string,!proto.system.Value>}
 */
proto.system.DictionaryValue.prototype.getObjectMap = function(opt_noLazyCreate) {
  return /** @type {!jspb.Map<string,!proto.system.Value>} */ (
      jspb.Message.getMapField(this, 1, opt_noLazyCreate,
      proto.system.Value));
};


/**
 * Clears values from the map. The map will be non-null.
 */
proto.system.DictionaryValue.prototype.clearObjectMap = function() {
  this.getObjectMap().clear();
};


goog.object.extend(exports, proto.system);
