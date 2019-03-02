namespace Trees

type ITree<'a> = 
    abstract member Value: 'a
    abstract member Children: seq<ITree<'a>>

module Tree = 
    let create value = 
    { new ITree<_> with
        member this.Value = value 
        member this.Children = Seq.empty }





