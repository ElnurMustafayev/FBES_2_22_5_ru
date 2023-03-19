#pragma once


namespace Aboba {
	class Showable {
	public:
		virtual void Show(sf::RenderWindow& window) = 0;
	};
}