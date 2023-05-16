namespace InterfacesApp;

using System.Collections;

public class Goods {
    public string Name { get; set; }

    public Goods(string name) {
        this.Name = name;
    }

    public override string ToString() => Name;
}

public class Shop : IEnumerable<Goods> {
    public List<Goods> Goods { get; set; } = new List<Goods>();
    private readonly IEnumerator<Goods> shopEnumerator;

    public Shop() {
        this.shopEnumerator = new ShopEnumerator(Goods);
    }

    public Shop(IEnumerator<Goods> enumerator) {
        this.shopEnumerator = enumerator;
    }

    IEnumerator IEnumerable.GetEnumerator() {
        return this.shopEnumerator;
    }

    public IEnumerator<Goods> GetEnumerator() {
        return this.shopEnumerator;
    }
}

public class ShopEnumerator : IEnumerator<Goods> {
    private readonly List<Goods> goods;
    private Goods currentGoods;
    private int index = 0;

    object IEnumerator.Current => this.currentGoods;
    public Goods Current => this.currentGoods;

    public ShopEnumerator(List<Goods> goods) {
        this.goods = goods;
    }

    public bool MoveNext() {
        if (index < goods.Count) {
            this.currentGoods = this.goods[index];
            index++;
            return true;
        }
        this.Reset();
        return false;
    }

    public void Reset() {
        this.index = 0;
    }

    public void Dispose() {
        
    }
}