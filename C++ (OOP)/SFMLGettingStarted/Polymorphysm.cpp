#include <SFML/Graphics.hpp>

void InitRandomParams(sf::Shape* shape, float speed) {
    srand(time(0));

    auto oldPos = shape->getPosition();
    shape->setPosition(oldPos.x + speed, oldPos.y + speed);

    shape->setFillColor(sf::Color(rand() % 256, rand() % 256, rand() % 256));
}

int Main()
{
    sf::RenderWindow window(sf::VideoMode(400, 400), "SFML works!");
    
    auto rect = sf::RectangleShape(sf::Vector2f(100, 50));
    auto circle = sf::CircleShape(50);

    sf::Shape* shape = &circle;

    while (window.isOpen())
    {
        sf::Event event;
        while (window.pollEvent(event))
        {
            if (event.type == sf::Event::Closed)
                window.close();

            /*if (event.type == sf::Event::MouseButtonPressed) {
                shape = (shape == &rect) ? (sf::Shape*)&circle : (sf::Shape*)&rect;
            }*/
        }
        InitRandomParams(&rect, 0.01);
        InitRandomParams(&circle, 0.02);

        window.clear();
        window.draw(rect);
        window.draw(circle);
        window.display();
    }

    return 0;
}