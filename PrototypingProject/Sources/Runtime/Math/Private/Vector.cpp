#include <Vector.h>

const PVector PVector::Zero = PVector(0.0f, 0.0f, 0.0f);
const PVector PVector::One = PVector(1.0f, 1.0f, 1.0f);
const PVector PVector::Up = PVector(0.0f, 1.0f, 0.0f);
const PVector PVector::Right = PVector(1.0f, 0.0f, 0.0f);
const PVector PVector::Forward = PVector(0.0f, 0.0f, 1.0f);

PVector::PVector()
{
}

PVector::PVector(float X, float Y, float Z)
	: x(X), y(Y), z(Z)
{
}

PVector PVector::Cross(const PVector & V1, const PVector & V2)
{
	return PVector(V1.y * V2.z - V1.z * V2.y,
		V1.z * V2.x - V1.x * V2.z, 
		V1.x * V2.y - V1.y * V2.x);
}

PVector PVector::Dot(const PVector & V1, const PVector & V2)
{
	return PVector(V1.x * V2.x, V1.y * V2.y, V1.z * V2.z);
}

PVector PVector::operator+(const PVector & V) const
{
	return PVector(x + V.x, y + V.y, z + V.z);
}

PVector PVector::operator-(const PVector & V) const
{
	return PVector(x - V.x, y - V.y, z - V.z);
}

PVector PVector::operator+=(const PVector & V) const
{
	return PVector(x + V.x, y + V.y, z + V.z);
}

PVector PVector::operator-=(const PVector & V) const
{
	return PVector(x - V.x, y - V.y, z - V.z);
}

PVector PVector::operator/=(const float & F) const
{
	return PVector(x / F, y / F, z /F);
}

PVector PVector::operator*=(const float & F) const
{
	return PVector(x * F, y * F, z * F);
}

PVector operator*(const PVector & V, const float & F)
{
	return PVector(V.x * F, V.y * F, V.z * F);
}

PVector operator*(const float & F, const PVector & V)
{
	return PVector(V.x * F, V.y * F, V.z * F);
}

PVector operator/(const PVector & V, const float & F)
{
	return PVector(V.x / F, V.y / F, V.z / F);
}

PVector operator/(const float & F, const PVector & V)
{
	return PVector(V.x / F, V.y / F, V.z / F);
}


PVector4::PVector4()
{
}

PVector4::PVector4(float X, float Y, float Z, float W)
	: x(X), y(Y), z(Z), w(W)
{
}

PVector4::PVector4(float X, float Y, float Z, bool IsPoint)
	: x(X), y(Y), z(Z), w(IsPoint ? 1.0 : 0.0)
{
}

PVector4::PVector4(PVector V, bool IsPoint)
	: x(V.x), y(V.y), z(V.z), w(IsPoint ? 1.0 : 0.0)
{
}

PVector PVector4::ToVector3() const
{
	return PVector(x, y, z);
}

PVector4 PVector4::operator+(const PVector4 & V) const
{
	return PVector4(x + V.x, y + V.y, z + V.z, w + V.w);
}

PVector4 PVector4::operator-(const PVector4 & V) const
{
	return PVector4(x - V.x, y - V.y, z - V.z, w - V.w);
}

PVector4 PVector4::operator+=(const PVector4 & V) const
{
	return PVector4(x + V.x, y + V.y, z + V.z, w + V.w);
}

PVector4 PVector4::operator-=(const PVector4 & V) const
{
	return PVector4(x - V.x, y - V.y, z - V.z, w - V.w);
}

PVector4 PVector4::operator/=(const float & F) const
{
	return PVector4(x / F, y / F, z / F, w / F);
}

PVector4 PVector4::operator*=(const float & F) const
{
	return PVector4(x * F, y * F, z * F, w * F);
}

PVector4 operator*(const PVector4 & V, const float & F)
{
	return PVector4(V.x * F, V.y * F, V.z * F, V.w * F);
}

PVector4 operator*(const float & F, const PVector4 & V)
{
	return PVector4(V.x * F, V.y * F, V.z * F, V.w * F);
}

PVector4 operator/(const PVector4 & V, const float & F)
{
	return PVector4(V.x / F, V.y / F, V.z / F, V.w / F);
}

PVector4 operator/(const float & F, const PVector4 & V)
{
	return PVector4(V.x / F, V.y / F, V.z / F, V.w / F);
}
