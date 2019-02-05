namespace Trees

type ITree<'a> = 
    abstract member Value: 'a
    abstract member Children: seq<ITree<'a>>







