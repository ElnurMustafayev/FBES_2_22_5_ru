#pragma once

namespace Aboba {
	class Text : Showable {
		int size;
		int posX;
		int posY;
		sf::Font font;
		sf::Text text;

	public:
		Text() {}

		Text(string& text, int posX = 0, int PosY = 0, int size = 50) : size(size), posY(posY), posX(posX)
		{
			this->font.loadFromFile("assets/BebasNeue-Regular.ttf");
			this->text = sf::Text(text, font);

			this->text.setCharacterSize(size);
			this->text.setStyle(sf::Text::Bold);
			this->text.setFillColor(sf::Color::White);
			this->text.setOutlineThickness(2);
			this->text.setOutlineColor(sf::Color::Black);
			this->text.setPosition(posX, posY);
		}

		void ChangeText(string text) {
			this->text = sf::Text(text, font);

			this->text.setCharacterSize(size);
			this->text.setStyle(sf::Text::Bold);
			this->text.setFillColor(sf::Color::White);
			this->text.setOutlineThickness(2);
			this->text.setOutlineColor(sf::Color::Black);
			this->text.setPosition(posX, posY);
		}

		void Show(sf::RenderWindow& window) override {
			window.draw(this->text);
		}
	};
}