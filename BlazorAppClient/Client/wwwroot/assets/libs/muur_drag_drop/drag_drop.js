var boardGameInstance;//DotNetObjectReference
var obj_grid_id_look_up;//object to look up the ids of the grids with the dotnet ids
function initBoardGameInstance(boardGameInstance_) {
    boardGameInstance = boardGameInstance_;
    obj_grid_id_look_up = new Object();
}

function initDragDrop() {
    var dragContainer = document.querySelector('.drag-container');
    var itemContainers = [].slice.call(document.querySelectorAll('.board-column-content'));
    var columnGrids = [];
    var boardGrid;

    // Init the column grids so we can drag those items around.
    itemContainers.forEach(function (container) {
        var grid = new Muuri(container, {
            items: '.board-item',
            dragEnabled: true,
            dragSort: function () {
                return columnGrids;
            },
            dragContainer: dragContainer,
            dragAutoScroll: {
                targets: (item) => {
                    return [
                        { element: window, priority: 0 },
                        { element: item.getGrid().getElement().parentNode, priority: 1 },
                    ];
                }
            },
        })
            .on('dragInit', function (item) {
                //kz
                //console.log('item dragInit', item);
                item.getElement().style.width = item.getWidth() + 'px';
                item.getElement().style.height = item.getHeight() + 'px';
            })
            .on('dragReleaseEnd', function (item) {
                //kz
                //console.log('dragged element id:', item.getElement().id);
                //console.log('parent grid id:', obj_grid_id_look_up[item._gridId]);
                //send the "title id" and the "item id" to be reordered
                boardGameInstance.invokeMethodAsync("ReorderGameBoardItemsOrdering", obj_grid_id_look_up[item._gridId], item.getElement().id);
                item.getElement().style.width = '';
                item.getElement().style.height = '';
                item.getGrid().refreshItems([item]);
            })
            .on('layoutStart', function () {
                boardGrid.refreshItems().layout();
            });
        //
        var items_array = [];//the items ids
        grid._items.forEach(function (_item, _index) {
            items_array.push(_item.getElement().id);//push into an array
        });
        //send the "title id" and the "items ids"
        boardGameInstance.invokeMethodAsync("InitGameBoardItemsOrdering", grid.getElement().id, items_array);
        //
        obj_grid_id_look_up[grid._id] = grid.getElement().id;//input the ids and the dotnet ids
        columnGrids.push(grid);
    });

    // Init board grid so we can drag those columns around.
    boardGrid = new Muuri('.board', {
        dragEnabled: true,
        dragHandle: '.board-column-header'
    });
}