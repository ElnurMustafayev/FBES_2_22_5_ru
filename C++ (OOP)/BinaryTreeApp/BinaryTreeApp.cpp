#include <iostream>
using namespace std;

#include "BinaryTree.h"


int main()
{
	BinaryTree<int> tree = BinaryTree<int>();

	tree.Add(8);
	tree.Add(10);
	tree.Add(14);
	tree.Add(13);
	tree.Add(3);
	tree.Add(6);
	tree.Add(1);
	tree.Add(7);
	tree.Add(4);

	tree.Show(tree.root);

	//cout << "Max: " << tree.Max() << endl;
	//cout << "Min: " << tree.Min() << endl;

	//auto found = tree.Get(7);
	//cout << found->parent->left->value << endl;
}