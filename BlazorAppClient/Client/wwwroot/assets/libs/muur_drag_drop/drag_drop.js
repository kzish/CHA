﻿var boardGameInstance;

function initBoardGameInstance(boardGameInstance_) {
    boardGameInstance = boardGameInstance_;
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
                console.log('item dragInit', item);
                item.getElement().style.width = item.getWidth() + 'px';
                item.getElement().style.height = item.getHeight() + 'px';
            })
            .on('dragReleaseEnd', function (item) {
                //kz
                console.log('element id:', item.getElement().id);
                console.log('parent:', item);
                item.getElement().style.width = '';
                item.getElement().style.height = '';
                item.getGrid().refreshItems([item]);
            })
            .on('layoutStart', function () {
                boardGrid.refreshItems().layout();
            });

        //kz
        var items_array = [];//the items ids
        grid._items.forEach(function (_item, _index)
        {
            items_array.push(_item.getElement().id);//push into an array
        });
        //send the title id and the items ids
        boardGameInstance.invokeMethodAsync("InitGameBoardItemsOrdering", grid.getElement().id, items_array);
        //
        columnGrids.push(grid);
    });

    // Init board grid so we can drag those columns around.
    boardGrid = new Muuri('.board', {
        dragEnabled: true,
        dragHandle: '.board-column-header'
    });
}