#pragma once

#include <SFML/Graphics.hpp>

namespace Aboba {
    class Hero : public Showable {
        int speed = 1;
        int animationCounter = 0;
        sf::IntRect rect;
        sf::Vector2f pos;
        sf::Vector2f size;
        sf::Sprite sprite;
        int scale = 1;
        int hp = 100;
        int attack = 10;
        int score = 0;
        Aboba::Text* scoreText;

    public:
        Hero(sf::Texture& texture, int width, int height, int speed = 1, int scale = 1) : speed(speed), scale(scale) {
            this->size = sf::Vector2f(width, height);
            this->rect = sf::IntRect(this->size.x * 0, this->size.y * 0, this->size.x, this->size.y);
            this->sprite = sf::Sprite(texture, this->rect);
            this->pos = sf::Vector2f(windowWidth / 2, windowHeight / 2);
            this->sprite.setPosition(this->pos);
            this->sprite.scale(this->scale, this->scale);

            std::string scoreTxt = "Score: ";
            //scoreTxt += this->score;
            this->scoreText = new Aboba::Text(scoreTxt, 10, 0);
        }

        void Go(sf::Event keyboardEvent) {
            int actualSpeed = this->speed;

            if (keyboardEvent.key.shift)
                actualSpeed *= 2;
            if (keyboardEvent.key.control)
                actualSpeed /= 2;

            switch (keyboardEvent.key.code) {
            case sf::Keyboard::D:
                this->rect.top = this->size.y * 7;
                this->rect.left = this->size.x * (this->animationCounter++ % 10);

                this->pos.x += actualSpeed;
                break;
            case sf::Keyboard::W:
                this->score += 10;
                this->rect.top = this->size.y * 6;
                this->rect.left = this->size.x * (this->animationCounter++ % 10);

                this->pos.y -= actualSpeed;
                break;
            case sf::Keyboard::A:
                this->rect.top = this->size.y * 5;
                this->rect.left = this->size.x * (this->animationCounter++ % 10);

                this->pos.x -= actualSpeed;
                break;
            case sf::Keyboard::S:
                this->rect.top = this->size.y * 4;
                this->rect.left = this->size.x * (this->animationCounter++ % 10);

                this->pos.y += actualSpeed;
                break;
            }

            string text = "Score: ";
            text += this->score;
            this->scoreText->ChangeText(text);

            this->sprite.setTextureRect(this->rect);
            this->sprite.setPosition(this->pos);

            cout << this->rect.left << this->rect.top << endl;
            cout << this->animationCounter << endl;
        }

        void Show(sf::RenderWindow& window) override {
            window.draw(this->sprite);

            this->scoreText->Show(window);
        }

        void operator - (Hero& hero) {
            hero.hp -= this->attack;
        }
    };
}