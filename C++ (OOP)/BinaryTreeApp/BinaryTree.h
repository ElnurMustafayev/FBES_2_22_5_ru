#pragma once

template<typename T>
struct BinaryTreeNode {
	BinaryTreeNode<T>* rigth = nullptr;
	BinaryTreeNode<T>* left = nullptr;
	BinaryTreeNode<T>* parent = nullptr;

	T value;

	BinaryTreeNode(T value) : value(value) {}
};


template<typename T>
class BinaryTree {
public:
	BinaryTreeNode<T>* root = nullptr;
	
	void Show(BinaryTreeNode<T>* current) {
		if (current == nullptr)
			return;

		Show(current->rigth);
		cout << current->value << endl;
		Show(current->left);
	}

	T Max() {
		if (this->root == nullptr)
			return -1;

		BinaryTreeNode<T>* cursor = root;

		while (cursor->rigth != nullptr) {
			cursor = cursor->rigth;
		}

		return cursor->value;
	}

	T Min() {
		if (this->root == nullptr)
			return -1;

		BinaryTreeNode<T>* cursor = root;

		while (cursor->left != nullptr) {
			cursor = cursor->left;
		}

		return cursor->value;
	}

	BinaryTreeNode<T>* Get(T value) {
		BinaryTreeNode<T>* cursor = root;

		while (cursor != nullptr) {
			if (cursor->value == value)
				return cursor;
			else if (value > cursor->value)
				cursor = cursor->rigth;
			else if (value < cursor->value)
				cursor = cursor->left;
		}

		return nullptr;
	}

	void Add(T value) {
		BinaryTreeNode<T>* newEl = new BinaryTreeNode<T>(value);

		if (this->root == nullptr) {
			this->root = newEl;
		}

		else {
			BinaryTreeNode<T>* cursor = this->root;

			while (true) {
				if (value == cursor->value) {
					delete newEl;
					return;
				}
				else if (value > cursor->value) {
					if (cursor->rigth == nullptr) {
						newEl->parent = cursor;
						cursor->rigth = newEl;
						return;
					}
					cursor = cursor->rigth;
				}
				else if (value < cursor->value) {
					if (cursor->left == nullptr) {
						newEl->parent = cursor;
						cursor->left = newEl;
						return;
					}
					cursor = cursor->left;
				}
			}
		}
	}
};