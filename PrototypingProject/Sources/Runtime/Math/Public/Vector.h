#pragma once
#include <MathDefine.h>
#include <PEngineMacros.h>

struct MATH_API PVector
{
public:
	float x;
	float y;
	float z;

public:

	static const PVector Zero;
	static const PVector One;
	static const PVector Up;
	static const PVector Right;
	static const PVector Forward;

	FORCEINLINE PVector();
	FORCEINLINE PVector(float X, float Y, float Z);

	//cross
	FORCEINLINE static PVector Cross(const PVector& V1, const PVector& V2);

	//dot
	FORCEINLINE static PVector Dot(const PVector& V1, const PVector& V2);

	FORCEINLINE PVector operator+(const PVector& V) const;
	FORCEINLINE PVector operator-(const PVector& V) const;

	FORCEINLINE PVector operator+=(const PVector& V) const;
	FORCEINLINE PVector operator-=(const PVector& V) const;

	FORCEINLINE PVector operator/=(const float& F) const;
	FORCEINLINE PVector operator*=(const float& F) const;
};

FORCEINLINE PVector operator* (const PVector& V, const float& F);
FORCEINLINE PVector operator* (const float& F, const PVector& V);
FORCEINLINE PVector operator/ (const PVector& V, const float& F);
FORCEINLINE PVector operator/ (const float& F, const PVector& V);

struct MATH_API PVector4
{
public:
	float x;
	float y;
	float z;
	float w;
public:

	static const PVector Zero;
	static const PVector One;
	static const PVector Up;
	static const PVector Right;
	static const PVector Forward;

	FORCEINLINE PVector4();
	FORCEINLINE PVector4(float X, float Y, float Z, float W);
	FORCEINLINE PVector4(float X, float Y, float Z, bool IsPoint);
	FORCEINLINE PVector4(PVector V, bool IsPoint);

	FORCEINLINE PVector ToVector3() const;

	FORCEINLINE PVector4 operator+(const PVector4& V) const;
	FORCEINLINE PVector4 operator-(const PVector4& V) const;

	FORCEINLINE PVector4 operator+=(const PVector4& V) const;
	FORCEINLINE PVector4 operator-=(const PVector4& V) const;

	FORCEINLINE PVector4 operator/=(const float& F) const;
	FORCEINLINE PVector4 operator*=(const float& F) const;
};

FORCEINLINE PVector4 operator* (const PVector4& V, const float& F);
FORCEINLINE PVector4 operator* (const float& F, const PVector4& V);
FORCEINLINE PVector4 operator/ (const PVector4& V, const float& F);
FORCEINLINE PVector4 operator/ (const float& F, const PVector4& V);