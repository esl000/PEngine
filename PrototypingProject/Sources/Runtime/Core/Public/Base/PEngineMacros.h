#pragma once

//temp include
#include <cassert>

#define SINGLETONE(class_name)\
private:\
	class_name(){}\
	~class_name(){}\
public:\
	static class_name* GetInstance()\
	{\
		static class_name instance;\
		return &instance;\
	}

#define PREFIX_PROPERTY_GET_SET(prefix, type_name, instance_name)\
prefix:\
	type_name instance_name;\
public:\
	type_name Get##instance_name() const {\
		return instance_name;\
	}\
	void Set##instance_name(type_name var) {\
		instance_name = var;\
	}

#define PREFIX_PROPERTY_GET(prefix, type_name, instance_name)\
prefix:\
	type_name instance_name;\
public:\
	type_name Get##instance_name() const {\
		return instance_name;\
	}

#define PREFIX_PROPERTY_SET(prefix, type_name, instance_name)\
prefix:\
	type_name instance_name;\
public:\
	void Set##instance_name(type_name var) {\
		instance_name = var;\
	}

#define PROPERTY_GET_SET(type_name, instance_name) PREFIX_PROPERTY_GET_SET(protected, type_name, instance_name)
#define PROPERTY_GET(type_name, instance_name) PREFIX_PROPERTY_GET(protected, type_name, instance_name)
#define PROPERTY_SET(type_name, instance_name) PREFIX_PROPERTY_SET(protected, type_name, instance_name)

#define PREFIX_PROPERTY(prefix, type_name, instance_name) PREFIX_PROPERTY_GET_SET(prefix, type_name, instance_name)
#define PROPERTY(type_name, instance_name) PREFIX_PROPERTY_GET_SET(protected, type_name, instance_name)

#define SUCCEEDED(hr)   (((HRESULT)(hr)) >= 0)
#define FAILED(hr)      (((HRESULT)(hr)) < 0)

#define ASSERT_SUCCEEDED(hr)   assert((((HRESULT)(hr)) >= 0));
