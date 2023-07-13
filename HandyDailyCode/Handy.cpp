#include "Handy.h"

Handy::Handy() {

}

Handy::Handy(int h) {
	this->h = h;
}

Handy::~Handy() {

}

const Handy operator*(const Handy& lhs, const Handy& rhs) {
	 int result = (lhs.h * rhs.h);
	 return Handy(result);
}